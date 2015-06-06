#include <tizen.h>
#include "helloworld.h"
#include <bluetooth.h>
#include <dlog.h>
#include <glib.h>
#include <string.h>
#include <pthread.h>
#include <time.h>
///// 통신 1 주석
#include <curl/curl.h>
#include <sys/types.h>
#include <unistd.h>
#include <stdlib.h>
#include <signal.h>
//////

#ifdef LOG_TAG
#undef LOG_TAG
#endif
#define LOG_TAG "APAMS"

#define ICON_DIR "/opt/usr/apps/org.tizen.helloworld/res/images"
#define ELM_DEMO_EDJ "/opt/usr/apps/org.tizen.helloworld/res/ui_controls.edj"

// 테스트용
static int scenario = 0;

// * Static Global *
static int chart_x[8] = { 32, 96, 160, 224, 288, 352, 416 };
static int population[8] = { 1, 2, 3, 1, 2, 3, 1 };

static int beacon_1[] = { 155, 235 };
static int beacon_2[] = { 265, 130 };
static int beacon_3[] = { 155, 325 };
static int beacon_4[] = { 310, 180 };
static int stamp_flag = 0;

static int beacon_popul[] = { 1, 1, 1, 1 };

static GMainLoop* g_mainloop = NULL;
static bt_adapter_state_e bt_state = BT_ADAPTER_DISABLED;

static pthread_t thread_id;
static Eina_Bool thread_finish = EINA_FALSE;
static Eina_Bool splash_flag = EINA_TRUE;

// 통통배
int tmpCnt = 0;   // 추가
char sendString2server[100];   // 추가
char emptyString[100];   // 추가
char statistics[300] = "functionid=4";
char event[300] = "functionid=3";
char map[300] = "functionid=2";
char waittime[300] = "functionid=5";
typedef struct curlResponseData {
	char *response;
	size_t size;
} CURL_RES_DATA;   // 추가
// 통신 2
char* beaconSet[4] = {"78:A5:04:4F:39:58", "78:A5:04:4F:06:82",
			"78:A5:04:4F:4D:9E", "78:A5:04:4F:3A:DC" };
	int beaconNum[4] = { 0, 0, 0, 0 };
	char* map_temp;		// = strtok(resData.response, "/");
	char* map_tempN;
	char* strWait="";

///

typedef struct appdata {
	// * Window *
	Evas_Object* win;

	// * Layouts *
	Evas_Object* layout_main;      // Main
	Evas_Object* layout_map;      // Map & Population
	Evas_Object* conform;		// Conform for wait
	Evas_Object* nf;			// Naviframe for wait
	Evas_Object* layout_wait;      // Waiting Time
	Evas_Object* layout_stamp;      // Stamapmp Event
	Evas_Object* layout_stats;      // Statitics

	// * Main Labels *
	Evas_Object* btn_map;   // If you click this, layout_map will be shown
	Evas_Object* btn_wait;   // If you click this, layout_wait will be shown
	Evas_Object* btn_stamp;   // If you click this, layout_stamp will be shown
	Evas_Object* btn_stats;   // If you click this, layout_stats will be shown

	// * Main Images *
	Evas_Object* main_bg;

	// * Map Labels *
	Evas *map_e;
	Evas_Object* grid1;
	Evas_Object* grid2;
	Evas_Object* map_bg;
	Evas_Object* map_circle;
	Evas_Object* map_bea1;
	Evas_Object* map_bea2;
	Evas_Object* map_bea3;
	Evas_Object* map_bea4;
	Evas_Object* btn_refresh1;
	Evas_Object* btn_back1; // If you click this, layout_main will be shown

	// * Wait Labels *
	Evas_Object* popup;
	Evas_Object* btn_back2; // If you click this, layout_main will be shown

	// * Stamp Labels *
	Evas* stamp_e;
	Evas_Object* stamp_image;
	Evas_Object* stamp_description;
	Evas_Object* stamp_star;
	Evas_Object* btn_refresh2;
	Evas_Object* btn_back3; // If you click this, layout_main will be shown

	// * Stats Labels *
	Evas* stat_e;
	Evas_Object* rect1;
	Evas_Object* rect2;
	Evas_Object* rect3;
	Evas_Object* rect4;
	Evas_Object* rect5;
	Evas_Object* rect6;
	Evas_Object* rect7;
	Evas_Object* btn_refresh4;
	Evas_Object* btn_back4; // If you click this, layout_main will be shown

} appdata_s;

/* 요기요
 // 통신 3
 void msleep(int ms) {
 struct timespec time;
 time.tv_sec = ms / 1000;
 time.tv_nsec = (ms % 1000) * (1000 * 1000);
 nanosleep(&time,NULL);
 }
 */

void initCurlResponseData(CURL_RES_DATA *res) {
	res->size = 0;
	res->response = malloc(res->size + 1);

	if (res->response == NULL) {
		fprintf(stderr, "malloc() failed\n");
		exit(EXIT_FAILURE);
	}

	res->response[0] = '\0';
} // 추가

size_t curlWriteFunction(void *ptr, size_t size, size_t nmemb,
		CURL_RES_DATA *res) {
	size_t newLen = res->size + size * nmemb;
	res->response = realloc(res->response, newLen + 1); // 동적메모리 할당
	if (res->response == NULL) {
		fprintf(stderr, "realloc() failed\n");
		exit(EXIT_FAILURE);
	}
	memcpy(res->response + res->size, ptr, size * nmemb);
	res->response[newLen] = '\0';
	res->size = newLen;

	return size * nmemb;
} // 추가
// 통신 3

typedef struct _win_data {
	Evas_Object *list;
	Evas_Object *win;
} win_data;

/*
 static void
 win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
 {
 ui_app_exit();
 }
 */

static void win_delete_request_cb(void *data, Evas_Object *obj,
		void *event_info) {
	void *thread_result;
	thread_finish = EINA_TRUE;
	pthread_join(thread_id, &thread_result); // When App is finished, thread will be also finished
	ui_app_exit();
}

static void list_selected_cb(void *data, Evas_Object *obj, void *event_info) {
	Elm_Object_Item *it = event_info;
	elm_list_item_selected_set(it, EINA_FALSE);
}

static Eina_Bool naviframe_pop_cb(void *data, Elm_Object_Item *it) {
	win_data *popup_data = (win_data *) data;
	popup_data->win = NULL;
	popup_data->list = NULL;
	free(popup_data);
	elm_theme_extension_del(NULL, ELM_DEMO_EDJ);
	return EINA_TRUE;
}

static void popup_btn_clicked_cb(void *data, Evas_Object *obj, void *event_info) {
	Evas_Object *popup = data;
	evas_object_del(popup);
}


static void list_it_image_text_cb1(void *data, Evas_Object *obj,
      void *event_info) {
   Evas_Object *popup;
   Evas_Object *layout;
   Evas_Object *btn;
   Evas_Object *img;
   Evas_Object *win = data;

   /////////////////////////////////////////////////


   /////////////////////////////////////////////////



   popup = elm_popup_add(win);
   elm_popup_align_set(popup, ELM_NOTIFY_ALIGN_FILL, 1.0);

   eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK,
         eext_popup_back_cb, NULL);
   elm_object_part_text_set(popup, "title,text", "자이로스핀");
   evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);




	///////////////////////////////////////////////////////////////////

	CURLcode res;
	char* httpURL = "http://apams.dothome.co.kr/select";

	CURL *ctx5 = curl_easy_init();

	const CURLcode rc = curl_easy_perform(ctx5);

	CURL_RES_DATA resData;




	initCurlResponseData(&resData);

	curl_easy_setopt(ctx5, CURLOPT_URL, httpURL);
	curl_easy_setopt(ctx5, CURLOPT_POSTFIELDS, map);

	curl_easy_setopt(ctx5, CURLOPT_POSTFIELDSIZE, (long )100);

	res = curl_easy_perform(ctx5);
	if (res != CURLE_OK)
		fprintf(stderr, "curl_easy_perform() failed: %s\n",
				curl_easy_strerror(res));

	curl_easy_setopt(ctx5, CURLOPT_WRITEDATA, &resData);
	curl_easy_setopt(ctx5, CURLOPT_WRITEFUNCTION, curlWriteFunction);

	//dlog_print(DLOG_DEBUG, LOG_TAG, "여기까진 됨");

	if ((res = curl_easy_perform(ctx5)) == CURLE_OK) { // 0 means ok
		//printf("Everything is OK.\n");
		//printf("%s\n", resData.response);
		//dlog_print(DLOG_INFO, LOG_TAG, "qqqqqqq? %s", resData.response);

		//dlog_print(DLOG_DEBUG, LOG_TAG, "받아온 스트링 : %s", resData.response);
		//dlog_print(DLOG_DEBUG, LOG_TAG, "받아온 스트링 : %s", resData.response);

		// notification_status_message_post(resData.response);

	} //else {
	  // dlog_print(DLOG_DEBUG, LOG_TAG, "else인데??");
	  //}
	curl_easy_cleanup(ctx5);


	// 밀집도 파싱

	/*dlog_print(DLOG_INFO, LOG_TAG, "z0%s", resData.response);

	map_temp = strtok(resData.response, "/");
	dlog_print(DLOG_INFO, LOG_TAG, "z1%s", map_temp);
	map_temp = strtok(NULL, "/");
	map_tempN = strtok(NULL, "/");
	dlog_print(DLOG_INFO, LOG_TAG, "z2%s", map_temp);
	dlog_print(DLOG_INFO, LOG_TAG, "z3%d", map_tempN);

	for (int i = 0; i < 4; i++) {
		if (strcmp(map_temp, beaconSet[i]) == 0) {
			beaconNum[i] = map_tempN[0] - '0';
			dlog_print(DLOG_INFO, LOG_TAG, "zz_1_%s---%s---%d", map_temp,
					map_tempN, beaconNum[i]);
			break;
		}
	}
	free(resData.response);
	dlog_print(DLOG_INFO, LOG_TAG, "zz_1_%d", beaconNum[0]);
	dlog_print(DLOG_INFO, LOG_TAG, "zz_1_%s", strWait);


	strcpy(strWait, "대기시간 : ");
	strcat(strWait, (beaconNum[0])+'0');
	dlog_print(DLOG_INFO, LOG_TAG, "zz_1_%s",strWait);
*/

   layout = elm_layout_add(popup);
   elm_layout_file_set(layout, ELM_DEMO_EDJ, "popup_image_list_layout");
   elm_object_part_text_set(layout, "elm.text", strWait);
   evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND,
   EVAS_HINT_EXPAND);
   elm_object_content_set(popup, layout);

   /* image */
   img = elm_image_add(layout);
   elm_image_file_set(img, ICON_DIR"/ride_image1.png", NULL);
   elm_image_aspect_fixed_set(img, EINA_TRUE);
   elm_image_resizable_set(img, EINA_FALSE, EINA_FALSE);
   elm_object_part_content_set(layout, "elm.swallow.content", img);

   /* ok button */
   btn = elm_button_add(popup);
   elm_object_style_set(btn, "popup");
   elm_object_text_set(btn, "OK");
   elm_object_part_content_set(popup, "button1", btn);
   evas_object_smart_callback_add(btn, "clicked", popup_btn_clicked_cb, popup);

   evas_object_show(popup);
}


static void list_it_image_text_cb2(void *data, Evas_Object *obj,
      void *event_info) {
   Evas_Object *popup;
   Evas_Object *layout;
   Evas_Object *btn;
   Evas_Object *img;
   Evas_Object *win = data;

   popup = elm_popup_add(win);
   elm_popup_align_set(popup, ELM_NOTIFY_ALIGN_FILL, 1.0);

   eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK,
         eext_popup_back_cb, NULL);
   elm_object_part_text_set(popup, "title,text", "어린이범퍼카");
   evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

   layout = elm_layout_add(popup);
   elm_layout_file_set(layout, ELM_DEMO_EDJ, "popup_image_list_layout");
   elm_object_part_text_set(layout, "elm.text", "대기시간 : ");
   evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND,
   EVAS_HINT_EXPAND);
   elm_object_content_set(popup, layout);

   /* image */
   img = elm_image_add(layout);
   elm_image_file_set(img, ICON_DIR"/ride_image2.png", NULL);
   elm_image_aspect_fixed_set(img, EINA_TRUE);
   elm_image_resizable_set(img, EINA_FALSE, EINA_FALSE);
   elm_object_part_content_set(layout, "elm.swallow.content", img);

   /* ok button */
   btn = elm_button_add(popup);
   elm_object_style_set(btn, "popup");
   elm_object_text_set(btn, "OK");
   elm_object_part_content_set(popup, "button1", btn);
   evas_object_smart_callback_add(btn, "clicked", popup_btn_clicked_cb, popup);

   evas_object_show(popup);
}

static void list_it_image_text_cb3(void *data, Evas_Object *obj,
      void *event_info) {
   Evas_Object *popup;
   Evas_Object *layout;
   Evas_Object *btn;
   Evas_Object *img;
   Evas_Object *win = data;

   popup = elm_popup_add(win);
   elm_popup_align_set(popup, ELM_NOTIFY_ALIGN_FILL, 1.0);

   eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK,
         eext_popup_back_cb, NULL);
   elm_object_part_text_set(popup, "title,text", "아틀란티스");
   evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

   layout = elm_layout_add(popup);
   elm_layout_file_set(layout, ELM_DEMO_EDJ, "popup_image_list_layout");
   elm_object_part_text_set(layout, "elm.text", "대기시간 : ");
   evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND,
   EVAS_HINT_EXPAND);
   elm_object_content_set(popup, layout);

   /* image */
   img = elm_image_add(layout);
   elm_image_file_set(img, ICON_DIR"/ride_image3.png", NULL);
   elm_image_aspect_fixed_set(img, EINA_TRUE);
   elm_image_resizable_set(img, EINA_FALSE, EINA_FALSE);
   elm_object_part_content_set(layout, "elm.swallow.content", img);

   /* ok button */
   btn = elm_button_add(popup);
   elm_object_style_set(btn, "popup");
   elm_object_text_set(btn, "OK");
   elm_object_part_content_set(popup, "button1", btn);
   evas_object_smart_callback_add(btn, "clicked", popup_btn_clicked_cb, popup);

   evas_object_show(popup);
}

static void list_it_image_text_cb4(void *data, Evas_Object *obj,
      void *event_info) {
   Evas_Object *popup;
   Evas_Object *layout;
   Evas_Object *btn;
   Evas_Object *img;
   Evas_Object *win = data;

   popup = elm_popup_add(win);
   elm_popup_align_set(popup, ELM_NOTIFY_ALIGN_FILL, 1.0);

   eext_object_event_callback_add(popup, EEXT_CALLBACK_BACK,
         eext_popup_back_cb, NULL);
   elm_object_part_text_set(popup, "title,text", "스페인 해적선");
   evas_object_size_hint_weight_set(popup, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

   layout = elm_layout_add(popup);
   elm_layout_file_set(layout, ELM_DEMO_EDJ, "popup_image_list_layout");
   elm_object_part_text_set(layout, "elm.text", "대기시간 : ");
   evas_object_size_hint_weight_set(layout, EVAS_HINT_EXPAND,
   EVAS_HINT_EXPAND);
   elm_object_content_set(popup, layout);

   /* image */
   img = elm_image_add(layout);
   elm_image_file_set(img, ICON_DIR"/ride_image4.png", NULL);
   elm_image_aspect_fixed_set(img, EINA_TRUE);
   elm_image_resizable_set(img, EINA_FALSE, EINA_FALSE);
   elm_object_part_content_set(layout, "elm.swallow.content", img);

   /* ok button */
   btn = elm_button_add(popup);
   elm_object_style_set(btn, "popup");
   elm_object_text_set(btn, "OK");
   elm_object_part_content_set(popup, "button1", btn);
   evas_object_smart_callback_add(btn, "clicked", popup_btn_clicked_cb, popup);

   evas_object_show(popup);
}


static void win_back_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

static void create_list_view(appdata_s *ad) {
	Evas_Object *list;
	Evas_Object *btn;
	Evas_Object *nf = ad->nf;
	Elm_Object_Item *nf_it;

	/* List */
	list = elm_list_add(nf);
	elm_list_mode_set(list, ELM_LIST_COMPRESS);
	evas_object_smart_callback_add(list, "selected", list_selected_cb, NULL);

	/* Main Menu Items Here */
	elm_list_item_append(list, "자이로스핀", NULL, NULL, list_it_image_text_cb1,
			ad->win);
	elm_list_item_append(list, "어린이범퍼카", NULL, NULL, list_it_image_text_cb2,
			ad->win);
	elm_list_item_append(list, "아틀란티스", NULL, NULL, list_it_image_text_cb3,
			ad->win);
	elm_list_item_append(list, "스페인해적선", NULL, NULL, list_it_image_text_cb4,
			ad->win);

	elm_list_go(list);

	/* This button is set for devices which doesn't have H/W back key. */
	btn = elm_button_add(nf);
	elm_object_style_set(btn, "naviframe/end_btn/default");
	nf_it = elm_naviframe_item_push(nf, "놀이기구정보", btn, NULL, list, NULL);
	elm_naviframe_item_pop_cb_set(nf_it, naviframe_pop_cb, ad->win);

}

static Evas_Object*
create_img(Evas_Object *parent, char *filename) {
	Evas_Object *img;
	char buf[PATH_MAX];

	img = elm_image_add(parent);
	snprintf(buf, sizeof(buf), "%s/%s", ICON_DIR, filename);
	elm_image_file_set(img, buf, NULL);
	evas_object_show(img);

	return img;
}

static void btn_clicked_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;

	// dlog_print(DLOG_INFO, LOG_TAG, "Clicked Button Number: %d", num);
	if (strcmp("btn_map", evas_object_name_get(obj)) == 0) {
		/////////////////////////////////////////////////////////
		CURLcode res;
		char* httpURL = "http://apams.dothome.co.kr/select";

		CURL *ctx4 = curl_easy_init();

		const CURLcode rc = curl_easy_perform(ctx4);

		CURL_RES_DATA resData;

		initCurlResponseData(&resData);

		curl_easy_setopt(ctx4, CURLOPT_URL, httpURL);
		curl_easy_setopt(ctx4, CURLOPT_POSTFIELDS, map);

		curl_easy_setopt(ctx4, CURLOPT_POSTFIELDSIZE, (long )100);

		res = curl_easy_perform(ctx4);
		if (res != CURLE_OK)
			fprintf(stderr, "curl_easy_perform() failed: %s\n",
					curl_easy_strerror(res));

		curl_easy_setopt(ctx4, CURLOPT_WRITEDATA, &resData);
		curl_easy_setopt(ctx4, CURLOPT_WRITEFUNCTION, curlWriteFunction);

		//dlog_print(DLOG_DEBUG, LOG_TAG, "여기까진 됨");

		if ((res = curl_easy_perform(ctx4)) == CURLE_OK) { // 0 means ok
			//printf("Everything is OK.\n");
			//printf("%s\n", resData.response);
			//dlog_print(DLOG_INFO, LOG_TAG, "qqqqqqq? %s", resData.response);

			//dlog_print(DLOG_DEBUG, LOG_TAG, "받아온 스트링 : %s", resData.response);
			//dlog_print(DLOG_DEBUG, LOG_TAG, "받아온 스트링 : %s", resData.response);

			// notification_status_message_post(resData.response);

		} //else {
		  // dlog_print(DLOG_DEBUG, LOG_TAG, "else인데??");
		  //}
		curl_easy_cleanup(ctx4);

		dlog_print(DLOG_INFO, LOG_TAG, "z%s", resData.response);
		free(resData.response);

		////////////////////////////////////////////////////////
		evas_object_hide(ad->layout_main);
		//evas_object_hide(ad->layout_main_sub1);
		//evas_object_hide(ad->layout_main_sub2);
		evas_object_show(ad->layout_map);
	} else if (strcmp("btn_wait", evas_object_name_get(obj)) == 0) {
		////////////////////////////////////////////////////////////////////

		//////////////////////////////////////////////////////////////////////
		evas_object_hide(ad->layout_main);
		//evas_object_hide(ad->layout_main_sub1);
		//evas_object_hide(ad->layout_main_sub2);
		evas_object_show(ad->btn_back2);
		evas_object_show(ad->conform);
		evas_object_show(ad->layout_wait);
	} else if (strcmp("btn_stamp", evas_object_name_get(obj)) == 0) {

		CURLcode res;
		char* httpURL = "http://apams.dothome.co.kr/select";

		CURL *ctx3 = curl_easy_init();

		const CURLcode rc = curl_easy_perform(ctx3);

		CURL_RES_DATA resData;

		initCurlResponseData(&resData);

		curl_easy_setopt(ctx3, CURLOPT_URL, httpURL);
		curl_easy_setopt(ctx3, CURLOPT_POSTFIELDS, event);

		curl_easy_setopt(ctx3, CURLOPT_POSTFIELDSIZE, (long )100);

		res = curl_easy_perform(ctx3);
		if (res != CURLE_OK)
			fprintf(stderr, "curl_easy_perform() failed: %s\n",
					curl_easy_strerror(res));

		curl_easy_setopt(ctx3, CURLOPT_WRITEDATA, &resData);
		curl_easy_setopt(ctx3, CURLOPT_WRITEFUNCTION, curlWriteFunction);

		//dlog_print(DLOG_DEBUG, LOG_TAG, "여기까진 됨");

		if ((res = curl_easy_perform(ctx3)) == CURLE_OK) { // 0 means ok
			printf("Everything is OK.\n");
			printf("%s\n", resData.response);
			dlog_print(DLOG_INFO, LOG_TAG, "qqqqqqq? %s", resData.response);
//
//			//dlog_print(DLOG_DEBUG, LOG_TAG, "받아온 스트링 : %s", resData.response);
//			//dlog_print(DLOG_DEBUG, LOG_TAG, "받아온 스트링 : %s", resData.response);
//
//			// notification_status_message_post(resData.response);
//
		} //else {
//		  // dlog_print(DLOG_DEBUG, LOG_TAG, "else인데??");
//		  //}
		curl_easy_cleanup(ctx3);
//
		dlog_print(DLOG_INFO, LOG_TAG, "z%s", resData.response);
		free(resData.response);

		evas_object_hide(ad->layout_main);
		//evas_object_hide(ad->layout_main_sub1);
		//evas_object_hide(ad->layout_main_sub2);
		evas_object_show(ad->layout_stamp);
	} else if (strcmp("btn_stats", evas_object_name_get(obj)) == 0) {
		////////////////////////////////////////

		CURLcode res;
		char* httpURL = "http://apams.dothome.co.kr/select";

		CURL *ctx2 = curl_easy_init();

		const CURLcode rc = curl_easy_perform(ctx2);

		CURL_RES_DATA resData;

		initCurlResponseData(&resData);

		curl_easy_setopt(ctx2, CURLOPT_URL, httpURL);
		curl_easy_setopt(ctx2, CURLOPT_POSTFIELDS, statistics);

		curl_easy_setopt(ctx2, CURLOPT_POSTFIELDSIZE, (long )100);

		res = curl_easy_perform(ctx2);
		if (res != CURLE_OK)
			fprintf(stderr, "curl_easy_perform() failed: %s\n",
					curl_easy_strerror(res));

		curl_easy_setopt(ctx2, CURLOPT_WRITEDATA, &resData);
		curl_easy_setopt(ctx2, CURLOPT_WRITEFUNCTION, curlWriteFunction);

		//dlog_print(DLOG_DEBUG, LOG_TAG, "여기까진 됨");

		if ((res = curl_easy_perform(ctx2)) == CURLE_OK) { // 0 means ok
			//printf("Everything is OK.\n");
			//printf("%s\n", resData.response);
			//dlog_print(DLOG_INFO, LOG_TAG, "qqqqqqq? %s", resData.response);

			//dlog_print(DLOG_DEBUG, LOG_TAG, "받아온 스트링 : %s", resData.response);
			//dlog_print(DLOG_DEBUG, LOG_TAG, "받아온 스트링 : %s", resData.response);

			// notification_status_message_post(resData.response);

		} //else {
		  // dlog_print(DLOG_DEBUG, LOG_TAG, "else인데??");
		  //}
		curl_easy_cleanup(ctx2);

		dlog_print(DLOG_INFO, LOG_TAG, "z%s", resData.response);
		free(resData.response);

		////////////////////////////////////////
		evas_object_hide(ad->layout_main);
		evas_object_show(ad->layout_stats);
	} else if (strcmp("btn_back1", evas_object_name_get(obj)) == 0) {
		evas_object_hide(ad->layout_map);
		evas_object_show(ad->layout_main);
		//evas_object_show(ad->layout_main_sub1);
		//evas_object_show(ad->layout_main_sub2);
	} else if (strcmp("btn_back2", evas_object_name_get(obj)) == 0) {
		evas_object_hide(ad->conform);
		evas_object_hide(ad->layout_wait);
		evas_object_show(ad->layout_main);
		evas_object_hide(ad->btn_back2);
		//evas_object_show(ad->layout_main_sub1);
		//evas_object_show(ad->layout_main_sub2);
	} else if (strcmp("btn_back3", evas_object_name_get(obj)) == 0) {
		evas_object_hide(ad->layout_stamp);
		evas_object_show(ad->layout_main);
		//evas_object_show(ad->layout_main_sub1);
		//evas_object_show(ad->layout_main_sub2);
	} else if (strcmp("btn_back4", evas_object_name_get(obj)) == 0) {
		evas_object_hide(ad->layout_stats);
		evas_object_show(ad->layout_main);
		//evas_object_show(ad->layout_main_sub1);
		//evas_object_show(ad->layout_main_sub2);
	}

}

static void btn_clicked_color_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;

	evas_object_color_set(ad->btn_map, rand() % 254, rand() % 254, rand() % 254,
			rand() % 254);
	evas_object_color_set(ad->btn_wait, rand() % 254, rand() % 254,
			rand() % 254, rand() % 254);
	evas_object_color_set(ad->btn_stamp, rand() % 254, rand() % 254,
			rand() % 254, rand() % 254);
	evas_object_color_set(ad->main_bg, rand() % 254, rand() % 254, rand() % 254,
			rand() % 254);
}

// map refresh call back
static void refresh_clicked_cb(void *data, Evas_Object *obj, void *event_info) {


	appdata_s *ad = data;

	///////////////////////////////////////////////////////////////////

	CURLcode res;
	char* httpURL = "http://apams.dothome.co.kr/select";

	CURL *ctx4 = curl_easy_init();

	const CURLcode rc = curl_easy_perform(ctx4);

	CURL_RES_DATA resData;

	initCurlResponseData(&resData);

	curl_easy_setopt(ctx4, CURLOPT_URL, httpURL);
	curl_easy_setopt(ctx4, CURLOPT_POSTFIELDS, map);

	curl_easy_setopt(ctx4, CURLOPT_POSTFIELDSIZE, (long )100);

	res = curl_easy_perform(ctx4);
	if (res != CURLE_OK)
		fprintf(stderr, "curl_easy_perform() failed: %s\n",
				curl_easy_strerror(res));

	curl_easy_setopt(ctx4, CURLOPT_WRITEDATA, &resData);
	curl_easy_setopt(ctx4, CURLOPT_WRITEFUNCTION, curlWriteFunction);

	//dlog_print(DLOG_DEBUG, LOG_TAG, "여기까진 됨");

	if ((res = curl_easy_perform(ctx4)) == CURLE_OK) { // 0 means ok
		//printf("Everything is OK.\n");
		//printf("%s\n", resData.response);
		//dlog_print(DLOG_INFO, LOG_TAG, "qqqqqqq? %s", resData.response);

		//dlog_print(DLOG_DEBUG, LOG_TAG, "받아온 스트링 : %s", resData.response);
		//dlog_print(DLOG_DEBUG, LOG_TAG, "받아온 스트링 : %s", resData.response);

		// notification_status_message_post(resData.response);

	} //else {
	  // dlog_print(DLOG_DEBUG, LOG_TAG, "else인데??");
	  //}
	curl_easy_cleanup(ctx4);

	dlog_print(DLOG_INFO, LOG_TAG, "z%s", resData.response);

	// 밀집도 파싱


	map_temp = strtok(resData.response, "/");

	map_temp = strtok(NULL, "/");
	map_tempN = strtok(NULL, "/");

	for (int i = 0; i < 4; i++) {
		if (strcmp(map_temp, beaconSet[i]) == 0) {
			beaconNum[i] = map_tempN[0] - '0';
			dlog_print(DLOG_INFO, LOG_TAG, "zz_1_%s---%s---%d", map_temp,
					map_tempN, beaconNum[i]);
			break;
		}
	}

	map_temp = strtok(NULL, "/");
	map_tempN = strtok(NULL, "/");
	for (int i = 0; i < 4; i++) {
		if (strcmp(map_temp, beaconSet[i]) == 0) {
			beaconNum[i] = map_tempN[0] - '0';
			dlog_print(DLOG_INFO, LOG_TAG, "zz_2_%s---%s---%d", map_temp,
					map_tempN, beaconNum[i]);
			break;
		}
	}

	dlog_print(DLOG_INFO, LOG_TAG, "zz_11_%d---%d---", strlen(map_temp), strlen(beaconSet[1]));

	//dlog_print(DLOG_INFO, LOG_TAG, "zz_2_%s---%s", map_temp, map_tempN);

	map_temp = strtok(NULL, "/");
	map_tempN = strtok(NULL, "/");
	for (int i = 0; i < 4; i++) {
		if (strcmp(map_temp, beaconSet[i]) == 0) {
			beaconNum[i] = map_tempN[0] - '0';
			dlog_print(DLOG_INFO, LOG_TAG, "zz_3_%s---%s---%d", map_temp,
					map_tempN, beaconNum[i]);
			break;
		}
	}

	//dlog_print(DLOG_INFO, LOG_TAG, "zz_3_%s---%s", map_temp, map_tempN);

	map_temp = strtok(NULL, "/");
	map_tempN = strtok(NULL, "/");
	for (int i = 0; i < 4; i++) {
		if (strcmp(map_temp, beaconSet[i]) == 0) {
			beaconNum[i] = map_tempN[0] - '0';
			dlog_print(DLOG_INFO, LOG_TAG, "zz_4_%s---%s---%d", map_temp,
					map_tempN, beaconNum[i]);
			break;
		}
	}

	//dlog_print(DLOG_INFO, LOG_TAG, "zz_4_%s---%s", map_temp, map_tempN);
	dlog_print(DLOG_INFO, LOG_TAG, "zz%d%d%d%d", beaconNum[0], beaconNum[1],
			beaconNum[2], beaconNum[3]);

	free(resData.response);
	//////////////////////////////////////////////////////////////

	elm_grid_pack(ad->layout_map, ad->map_bea1,
			beacon_1[0] - (beacon_popul[0] + beaconNum[0])*60 / 2,
			beacon_1[1] - (beacon_popul[0] + beaconNum[0])*60 / 2,
			(beacon_popul[0] + beaconNum[0]) * 60,
			(beacon_popul[0] + beaconNum[0]) * 60);
	elm_grid_pack(ad->layout_map, ad->map_bea2,
			beacon_2[0] - (beacon_popul[1] + beaconNum[1])*60 / 2,
			beacon_2[1] - (beacon_popul[1] + beaconNum[1])*60 / 2,
			(beacon_popul[1] + beaconNum[1]) * 60,
			(beacon_popul[1] + beaconNum[1]) * 60);
	elm_grid_pack(ad->layout_map, ad->map_bea3,
			beacon_3[0] - (beacon_popul[2] + beaconNum[2])*60 / 2,
			beacon_3[1] - (beacon_popul[2] + beaconNum[2])*60 / 2,
			(beacon_popul[2] + beaconNum[2]) * 60,
			(beacon_popul[2] + beaconNum[2]) * 60);
	elm_grid_pack(ad->layout_map, ad->map_bea4,
			beacon_4[0] - (beacon_popul[3] + beaconNum[3])*60 / 2,
			beacon_4[1] - (beacon_popul[3] + beaconNum[3])*60 / 2,
			(beacon_popul[3] + beaconNum[3]) * 60,
			(beacon_popul[3] + beaconNum[3]) * 60);

}

static void stat_refresh_clicked_cb(void*data, Evas_Object* obj,
		void *event_info) {
	appdata_s *ad = data;

	population[6]++; // 통계자료 받아와서 증가시키는 부분

	elm_grid_pack(ad->layout_stats, ad->rect7, chart_x[6], 400 - 40 * population[6], 32, 200 + 40 * population[6]);

}

static void stamp_clicked_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	char buf_img[1024];
	char buf_des[1024];
	char buf_star[1024];

	switch (stamp_flag) {
	case 0:
		snprintf(buf_img, sizeof(buf_img), "%s/%s", ICON_DIR, "2_car.png");
		snprintf(buf_des, sizeof(buf_des), "%s",
				"<align=center><font_style=italic><b><font_size=25>어린이 범퍼카<br><br></font_size><font_size=15>귀여운 도전깜찍한 모양의 범퍼카를 타고 즐기는 아이들의 신나는 운전놀이!<br>앞에서 쾅~ 뒤에서 쿵~ <br>부딪힐 때마다 터지는 아이들의 즐거운 환호성!</font_size></b></font_style></align>");
		snprintf(buf_star, sizeof(buf_star), "%s/%s", ICON_DIR, "star_1.png");
		stamp_flag++;
//		evas_object_hide(ad->layout_stamp);
		break;
	case 1:
		snprintf(buf_img, sizeof(buf_img), "%s/%s", ICON_DIR, "2_car.png");
		snprintf(buf_des, sizeof(buf_des), "%s",
				"<align=center><font_style=italic><b><font_size=25>어린이 범퍼카<br><br></font_size><font_size=15>귀여운 도전깜찍한 모양의 범퍼카를 타고 즐기는 아이들의 신나는 운전놀이!<br>앞에서 쾅~ 뒤에서 쿵~ <br>부딪힐 때마다 터지는 아이들의 즐거운 환호성!</font_size></b></font_style></align>");
		snprintf(buf_star, sizeof(buf_star), "%s/%s", ICON_DIR, "star_1.png");
		stamp_flag++;
		break;
	case 2:
		snprintf(buf_img, sizeof(buf_img), "%s/%s", ICON_DIR, "3_atlantis.png");
		snprintf(buf_des, sizeof(buf_des), "%s",
				"<align=center><font_style=italic><b><font_size=25>아틀란티스<br><br></font_size><font_size=15>어트랙션의 혁명, 초고속 비행을 통한 최고의 스릴감~<br>롤러코스터와 후룸라이드의 절묘한 만남!<br>두 가지 어트랙션 묘미에 관람까지!<br>업그레이드 된 놀이시설의 혁명!</font_size></b></font_style></align>");
		snprintf(buf_star, sizeof(buf_star), "%s/%s", ICON_DIR, "star_2.png");
		stamp_flag++;
		break;
	case 3:
		snprintf(buf_img, sizeof(buf_img), "%s/%s", ICON_DIR, "4_pirate.png");
		snprintf(buf_des, sizeof(buf_des), "%s",
				"<align=center><font_style=italic><b><font_size=25>스페인 해적선<br><br></font_size><font_size=15>거친 파도에 휩쓸려 내려갈 것 같은 아찔함!<br>스페인 해적선에 탑승하면 그 순간 난 해적이 되어 긴장감은 절정!<br>저 거친 파도에 맞서 스릴의 세계로~!</font_size></b></font_style></align>");
		snprintf(buf_star, sizeof(buf_star), "%s/%s", ICON_DIR, "star_3.png");
		stamp_flag++;
		break;
	case 4:
		snprintf(buf_img, sizeof(buf_img), "%s/%s", ICON_DIR,
				"stamp_complete.png");
		snprintf(buf_des, sizeof(buf_des), "%s",
				"<align=center><font_style=italic><b><font_size=35>축하드립니다!!<br><br></font_size><font_size=25>스탬프를 모두 모았어요!<br>기념품매장에서 기념품을 받아가세요~!<br></font_size></b></font_style></align>");
		snprintf(buf_star, sizeof(buf_star), "%s/%s", ICON_DIR, "star_4.png");
		stamp_flag++;
		break;
	case 5:
		snprintf(buf_img, sizeof(buf_img), "%s/%s", ICON_DIR, "1_spin.png");
		snprintf(buf_des, sizeof(buf_des), "%s",
				"<align=center><font_style=italic><b><font_size=25>자이로스핀<br><br></font_size><font_size=15>롯데월드 자이로 시리즈, 그 세 번째!<br>아시아 최초 저소음 무진동 회전 어트랙션!<br>입이 쩍~ 벌어지는 놀라운 스피드를 경험해 보세요!</font_size></b></font_style></align>");
		snprintf(buf_star, sizeof(buf_star), "%s/%s", ICON_DIR, "star_0.png");
		stamp_flag = 0;
		break;
	}

	elm_image_file_set(ad->stamp_image, buf_img, NULL);
	elm_object_text_set(ad->stamp_description, buf_des);
	elm_image_file_set(ad->stamp_star, buf_star, NULL);

	evas_object_show(ad->layout_stamp);

}

gboolean timeout_func(gpointer data) {
	LOGE("[%s] Timeout.", __FUNCTION__);
	if (g_mainloop) {
		g_main_loop_quit((GMainLoop*) data);
	}

	return FALSE;
}

void bt_state_changed_impl(int result, bt_adapter_state_e adapter_state,
		void* user_data) {
	if (adapter_state == BT_ADAPTER_ENABLED) {
		if (result == BT_ERROR_NONE) {
			LOGI("[%s] Callback: BT was enabled successfully.", __FUNCTION__);
			bt_state = BT_ADAPTER_ENABLED;
		} else {
			LOGE("[%s] Callback: Failed to enable BT.", __FUNCTION__);
		}
	}

	if (g_mainloop) {
		g_main_loop_quit(g_mainloop);
	}
}

void bt_adapter_le_device_discovery_state_changed_imp(int result,
		bt_adapter_le_device_discovery_state_e discovery_state,
		bt_adapter_le_device_discovery_info_s *discovery_info, void *user_data) {
	if (result != BT_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG,
				"[adapter_device_discovery_state_changed_cb] Failed! result(%d).",
				result);

		return;
	}
	GList** searched_device_list = (GList**) user_data;
	switch (discovery_state) {
	case BT_ADAPTER_DEVICE_DISCOVERY_STARTED:
		dlog_print(DLOG_INFO, LOG_TAG, "BT_ADAPTER_DEVICE_DISCOVERY_STARTED");
		break;
	case BT_ADAPTER_DEVICE_DISCOVERY_FINISHED:
		dlog_print(DLOG_INFO, LOG_TAG, "BT_ADAPTER_DEVICE_DISCOVERY_FINISHED");
		break;
	case BT_ADAPTER_DEVICE_DISCOVERY_FOUND:
		dlog_print(DLOG_INFO, LOG_TAG, "BT_ADAPTER_DEVICE_DISCOVERY_FOUND");
		if (discovery_info != NULL) {
			dlog_print(DLOG_INFO, LOG_TAG, "Device Address: %s",
					discovery_info->remote_address);
			dlog_print(DLOG_INFO, LOG_TAG, "Device RSSI: %d",
					discovery_info->rssi);

			bt_adapter_device_discovery_info_s * new_device_info = malloc(
					sizeof(bt_adapter_device_discovery_info_s));

			if (new_device_info != NULL) {
				memcpy(new_device_info, discovery_info,
						sizeof(bt_adapter_device_discovery_info_s));
				new_device_info->remote_address = strdup(
						discovery_info->remote_address);
				new_device_info->rssi = discovery_info->remote_address;
				*searched_device_list = g_list_append(*searched_device_list,
						(gpointer) new_device_info);

				// 통신 4 - 블루투스 서버에 전송
				strcat(sendString2server, "trash=asd");
				strcat(sendString2server, "&functionid=1");
				strcat(sendString2server, "&beaconid=");
				strcat(sendString2server, discovery_info->remote_address);
				strcat(sendString2server, "&rssi=");
				sprintf(emptyString, "%d", discovery_info->rssi);
				//strcat(sendString2server, *itoa(discovery_info->rssi, emptyString, 10));
				strcat(sendString2server, emptyString);
				strcat(sendString2server, "&phoneid=1");
				//dlog_print(DLOG_INFO, LOG_TAG, "howd? %s", sendString2server);

				CURLcode res;
				char* httpURL = "http://apams.dothome.co.kr/select";

				CURL *ctx = curl_easy_init();

				//const CURLcode rc = curl_easy_perform(ctx);

				//CURL_RES_DATA resData;

				//initCurlResponseData(&resData);

				curl_easy_setopt(ctx, CURLOPT_URL, httpURL);
				curl_easy_setopt(ctx, CURLOPT_POSTFIELDS, sendString2server);

				curl_easy_setopt(ctx, CURLOPT_POSTFIELDSIZE, (long )100);
				//dlog_print(DLOG_INFO, LOG_TAG, "howd? %s", sendString2server);
				//strcpy(sendString2server, " ");
				dlog_print(DLOG_INFO, LOG_TAG, "howd? %s", sendString2server);

				res = curl_easy_perform(ctx);
				if (res != CURLE_OK)
					fprintf(stderr, "curl_easy_perform() failed: %s\n",
							curl_easy_strerror(res));

				/*curl_easy_setopt(ctx, CURLOPT_WRITEDATA, &resData);
				 curl_easy_setopt(ctx, CURLOPT_WRITEFUNCTION, curlWriteFunction);

				 dlog_print(DLOG_DEBUG, LOG_TAG, "여기까진 됨");

				 if ((res = curl_easy_perform(ctx)) == CURLE_OK) { // 0 means ok
				 printf("Everything is OK.\n");
				 printf("%s\n", resData.response);
				 dlog_print(DLOG_DEBUG, LOG_TAG, "받아온 스트링 : %s", resData.response);
				 // notification_status_message_post(resData.response);

				 } else {
				 dlog_print(DLOG_DEBUG, LOG_TAG, "else인데??");
				 }
				 */
				curl_easy_cleanup(ctx);

				//            free(resData.response);

				strcpy(sendString2server, " ");
				usleep(1000);
				// 추가 여기까지

				// 통신 4

			}
		}
		break;
	}
}

int blue_setting() {
	g_mainloop = g_main_loop_new(NULL, FALSE);
	int timeout_id = -1;

	LOGI("[%s] BLE discovering starts.", __FUNCTION__);

	// Initialize BT
	if (bt_initialize() != BT_ERROR_NONE) {
		LOGE("[%s] bt_initialize() failed.", __FUNCTION__);
		return -1;
	}

	if (bt_adapter_get_state(&bt_state) != BT_ERROR_NONE) {
		LOGE("[%s] bt_adapter_get_state() failed.", __FUNCTION__);
		return -1;
	}

	//   Enable BT
	if (bt_state == BT_ADAPTER_DISABLED) {
		if (bt_adapter_set_state_changed_cb(bt_state_changed_impl, NULL)
				!= BT_ERROR_NONE) {
			LOGE("[%s] bt_adapter_set_state_changed_cb() failed.",
					__FUNCTION__);
			return -1;
		}

		if (bt_adapter_enable() == BT_ERROR_NONE) {
			LOGI("[%s] bt_adapter_state_changed_cb will be called.",
					__FUNCTION__);
			timeout_id = g_timeout_add(60000, timeout_func, g_mainloop);
			g_main_loop_run(g_mainloop);
			g_source_remove(timeout_id);
		} else {
			LOGE("[%s] bt_adapter_enable() failed.", __FUNCTION__);
			return -1;
		}
	} else {
		LOGI("[%s] BT was already enabled.", __FUNCTION__);
	}

	bt_adapter_le_start_device_discovery();

	return 1;
}

void *
thread_safe_call_sync_cb(void *data) {
	//This function is in critical section.

	appdata_s *ad = data;

	dlog_print(DLOG_INFO, LOG_TAG, "<In the CS of the BLE Thread");

	//Return value passes to ecore_main_loop_thread_safe_call_sync() return value
	return NULL;
}

static void *
thread_run(void *data) {
	appdata_s *ad = data;

	int timer = 0;
	GList *devices_list = NULL; // BLE devices_list which have been found
	bt_error_e ret;

	// Bluetooth settings and start discovery
	blue_setting();

	// Setting the Connection with Server

	// Sleep 1 sec
	usleep(1000000);

	// Splash_Flag True -> False
	splash_flag = EINA_FALSE;

	// BLE Loop
	while (!thread_finish) {
		// Get the BLE dicovery informations with using this function.
		ret = bt_adapter_le_set_device_discovery_state_changed_cb(
				bt_adapter_le_device_discovery_state_changed_imp,
				(void*) &devices_list);
		if (ret != BT_ERROR_NONE) {
			dlog_print(DLOG_ERROR, LOG_TAG,
					"[bt_adapter_set_device_discovery_state_changed_cb] Failed.");
		}

		// critical section
		ecore_main_loop_thread_safe_call_sync(thread_safe_call_sync_cb, &data);

		// Timer
		dlog_print(DLOG_ERROR, LOG_TAG, "BLE Thread is running... (For %d sec)",
				timer);
		usleep(1000000);
		timer++;
	}

	bt_deinitialize();
	LOGI("[%s] BLE discovering ends.", __FUNCTION__);

	pthread_exit(NULL);

	return NULL;
}

static void layout_back_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = data;
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

static void app_get_resource(const char *edj_file_in, char *edj_path_out,
		int edj_path_max) {
	char *res_path = app_get_resource_path();
	if (res_path) {
		snprintf(edj_path_out, edj_path_max, "%s%s", res_path, edj_file_in);
		free(res_path);
	}
}

static void create_base_gui(appdata_s *ad) {
	char edj_path[PATH_MAX] = { 0, };

	/* Window */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_conformant_set(ad->win, EINA_TRUE);
	elm_win_autodel_set(ad->win, EINA_TRUE);
	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win,
				(const int *) (&rots), 4);
	}
	evas_object_smart_callback_add(ad->win, "delete,request",
			win_delete_request_cb, NULL);

	/* Main Layout */
	ad->layout_main = elm_grid_add(ad->win);
	evas_object_size_hint_weight_set(ad->layout_main, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->layout_main);
	evas_object_name_set(ad->layout_main, "lay_main");
	elm_grid_size_set(ad->layout_main, 480, 800);

	/* Map Layout */
	ad->layout_map = elm_grid_add(ad->win);
	//elm_box_horizontal_set(ad->layout_map, 1);
	evas_object_size_hint_weight_set(ad->layout_map, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->layout_map);
	evas_object_name_set(ad->layout_map, "lay_map");
	elm_grid_size_set(ad->layout_map, 480, 800);

	/* Wait Layout */
	/*
	 ad->layout_wait = elm_box_add(ad->win);
	 elm_box_horizontal_set(ad->layout_wait, 1);
	 evas_object_size_hint_weight_set(ad->layout_wait, EVAS_HINT_EXPAND,
	 EVAS_HINT_EXPAND);
	 elm_win_resize_object_add(ad->win, ad->layout_wait);
	 evas_object_name_set(ad->layout_wait, "lay_wait");
	 */
	ad->conform = elm_conformant_add(ad->win);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);

	ad->layout_wait = elm_layout_add(ad->conform);
	evas_object_size_hint_weight_set(ad->layout_wait, EVAS_HINT_EXPAND,
			700 / 800);
	elm_layout_theme_set(ad->layout_wait, "layout", "application", "default");
	evas_object_show(ad->layout_wait);

	elm_object_content_set(ad->conform, ad->layout_wait);

	ad->nf = elm_naviframe_add(ad->layout_wait);
	create_list_view(ad);
	elm_object_part_content_set(ad->layout_wait, "elm.swallow.content", ad->nf);
	eext_object_event_callback_add(ad->nf, EEXT_CALLBACK_BACK,
			eext_naviframe_back_cb, NULL);
	eext_object_event_callback_add(ad->nf, EEXT_CALLBACK_MORE,
			eext_naviframe_more_cb, NULL);

	/* Stamp Layout */
	ad->layout_stamp = elm_box_add(ad->win);
	//elm_box_horizontal_set(ad->layout_stamp, 1);
	evas_object_size_hint_weight_set(ad->layout_stamp, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	elm_box_padding_set(ad->layout_stamp, 0, 15);
	elm_win_resize_object_add(ad->win, ad->layout_stamp);
	evas_object_name_set(ad->layout_stamp, "lay_stamp");

	/* Stats Layout */
	ad->layout_stats = elm_grid_add(ad->win);
	evas_object_size_hint_weight_set(ad->layout_stats, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->layout_stats);
	evas_object_name_set(ad->layout_stats, "lay_stats");
	elm_grid_size_set(ad->layout_stats, 480, 800);

	/* Main Labels */
	Evas *e = evas_object_evas_get(ad->layout_main);
	ad->main_bg = evas_object_image_add(e);
	ad->main_bg = create_img(ad->layout_main, "main_background.png");
	evas_object_resize(ad->main_bg, 480, 800);
	evas_object_show(ad->main_bg);
	elm_grid_pack(ad->layout_main, ad->main_bg, 0, 0, 480, 800);

	ad->btn_map = elm_button_add(ad->layout_main);
	elm_object_text_set(ad->btn_map, "지도");
	evas_object_smart_callback_add(ad->btn_map, "clicked", btn_clicked_cb, ad);
	evas_object_show(ad->btn_map);
	elm_grid_pack(ad->layout_main, ad->btn_map, 20, 20, 210, 100);
	evas_object_name_set(ad->btn_map, "btn_map");

	ad->btn_wait = elm_button_add(ad->layout_main);
	elm_object_text_set(ad->btn_wait, "놀이기구정보");
	evas_object_smart_callback_add(ad->btn_wait, "clicked", btn_clicked_cb, ad);
	evas_object_show(ad->btn_wait);
	elm_grid_pack(ad->layout_main, ad->btn_wait, 250, 20, 210, 100);
	evas_object_name_set(ad->btn_wait, "btn_wait");

	ad->btn_stamp = elm_button_add(ad->layout_main);
	elm_object_text_set(ad->btn_stamp, "이벤트");
	evas_object_smart_callback_add(ad->btn_stamp, "clicked", btn_clicked_cb,
			ad);
	evas_object_show(ad->btn_stamp);
	elm_grid_pack(ad->layout_main, ad->btn_stamp, 20, 680, 210, 100);
	evas_object_name_set(ad->btn_stamp, "btn_stamp");
//
	ad->btn_stats = elm_button_add(ad->layout_main);
	elm_object_text_set(ad->btn_stats, "방문 통계");
	evas_object_smart_callback_add(ad->btn_stats, "clicked", btn_clicked_cb,
			ad);
	evas_object_show(ad->btn_stats);
	elm_grid_pack(ad->layout_main, ad->btn_stats, 250, 680, 210, 100);
	evas_object_name_set(ad->btn_stats, "btn_stats");

	/* Map Labels */
	Evas *map_e = evas_object_evas_get(ad->layout_map);
	ad->map_bg = evas_object_image_add(map_e);
	ad->map_bg = create_img(ad->layout_map, "map_bg.png");
	//ad->map_bg = create_img(ad->layout_map, "stamp_image.png");
	evas_object_resize(ad->map_bg, 480, 480);
	elm_grid_pack(ad->layout_map, ad->map_bg, 0, 0, 480, 480);

	ad->btn_back1 = elm_button_add(ad->layout_map);
	elm_object_text_set(ad->btn_back1, "메인으로");
	evas_object_smart_callback_add(ad->btn_back1, "clicked", btn_clicked_cb,
			ad);
	evas_object_show(ad->btn_back1);
	elm_grid_pack(ad->layout_map, ad->btn_back1, 0, 740, 480, 40);
	evas_object_name_set(ad->btn_back1, "btn_back1");

	ad->btn_refresh1 = elm_button_add(ad->layout_map);
	elm_object_text_set(ad->btn_refresh1, "refresh");
	evas_object_smart_callback_add(ad->btn_refresh1, "clicked",
			refresh_clicked_cb, ad);
	evas_object_show(ad->btn_refresh1);
	elm_grid_pack(ad->layout_map, ad->btn_refresh1, 30, 30, 150, 40);
	evas_object_name_set(ad->btn_refresh1, "btn_refresh1");

	ad->map_bea1 = evas_object_image_add(map_e);
	ad->map_bea1 = create_img(ad->layout_map, "circle.png");
	evas_object_color_set(ad->map_bea1, 134, 229, 127, 200);
	elm_grid_pack(ad->layout_map, ad->map_bea1, beacon_1[0] - 60 / 2,
			beacon_1[1] - 60 / 2, beacon_popul[0], beacon_popul[0]);

	ad->map_bea2 = evas_object_image_add(map_e);
	ad->map_bea2 = create_img(ad->layout_map, "circle.png");
	evas_object_color_set(ad->map_bea2, 37, 36, 255, 200);
	elm_grid_pack(ad->layout_map, ad->map_bea2, beacon_2[0] - 60 / 2,
			beacon_2[1] - 60 / 2, beacon_popul[1], beacon_popul[1]);

	ad->map_bea3 = evas_object_image_add(map_e);
	ad->map_bea3 = create_img(ad->layout_map, "circle.png");
	evas_object_color_set(ad->map_bea3, 204, 61, 61, 200);
	elm_grid_pack(ad->layout_map, ad->map_bea3, beacon_3[0] - 120 / 2,
			beacon_3[1] - 120 / 2, beacon_popul[2], beacon_popul[2]);

	ad->map_bea4 = evas_object_image_add(map_e);
	ad->map_bea4 = create_img(ad->layout_map, "circle.png");
	evas_object_color_set(ad->map_bea4, 255, 94, 0, 150);
	elm_grid_pack(ad->layout_map, ad->map_bea4, beacon_4[0] - 120 / 2,
			beacon_4[1] - 120 / 2, beacon_popul[3], beacon_popul[3]);

	/* Wait Labels */
	ad->btn_back2 = elm_button_add(ad->win);
	elm_object_text_set(ad->btn_back2, "메인으로");
//	evas_object_size_hint_weight_set(ad->btn_back2, 480,
//	150);
	evas_object_resize(ad->btn_back2, 480, 100);
	evas_object_move(ad->btn_back2, 0, 700);
	evas_object_smart_callback_add(ad->btn_back2, "clicked", btn_clicked_cb,
			ad);
	evas_object_name_set(ad->btn_back2, "btn_back2");

	/* Stamp Labels */
	ad->btn_refresh2 = elm_button_add(ad->layout_stamp);
	elm_object_text_set(ad->btn_refresh2, "도장찍기");
	evas_object_size_hint_min_set(ad->btn_refresh2, 180, 50);
	evas_object_size_hint_weight_set(ad->btn_refresh2, EVAS_HINT_EXPAND, 0);
//	evas_object_resize(ad->btn_refresh2, 150, 80);
	evas_object_size_hint_align_set(ad->btn_refresh2, 0, 0);
	evas_object_smart_callback_add(ad->btn_refresh2, "clicked",
			stamp_clicked_cb, ad);
	evas_object_show(ad->btn_refresh2);
	elm_box_pack_end(ad->layout_stamp, ad->btn_refresh2);

	ad->stamp_e = evas_object_evas_get(ad->layout_stamp);
	ad->stamp_image = evas_object_image_add(ad->stamp_e);
	ad->stamp_image = create_img(ad->layout_stamp, "1_spin.png");
	evas_object_size_hint_weight_set(ad->stamp_image, EVAS_HINT_EXPAND,
	EVAS_HINT_EXPAND);
	evas_object_size_hint_align_set(ad->stamp_image, EVAS_HINT_FILL,
	EVAS_HINT_FILL);
	evas_object_show(ad->stamp_image);
	elm_box_pack_end(ad->layout_stamp, ad->stamp_image);

	ad->stamp_description = elm_label_add(ad->layout_stamp);
//	elm_label_line_wrap_set(ad->stamp_description, ELM_WRAP_MIXED);
	elm_label_wrap_width_set(ad->stamp_description, 400);
	elm_object_text_set(ad->stamp_description,
			"<align=center><font_style=italic><b><br><font_size=25>자이로스핀<br></font_size><font_size=15>롯데월드 자이로 시리즈, 그 세 번째!<br>아시아 최초 저소음 무진동 회전 어트랙션!<br>입이 쩍~ 벌어지는 놀라운 스피드를 경험해 보세요!</font_size></b></font_style></align>");
	evas_object_size_hint_weight_set(ad->stamp_description, EVAS_HINT_EXPAND,
			0.1);
//	evas_object_size_hint_align_set(ad->stamp_description, EVAS_HINT_FILL, EVAS_HINT_FILL);
	//evas_object_size_hint_align_set(ad->stamp_description, 0.5, 0.5);
	evas_object_show(ad->stamp_description);
	elm_box_pack_end(ad->layout_stamp, ad->stamp_description);

	ad->stamp_star = evas_object_image_add(ad->stamp_e);
	ad->stamp_star = create_img(ad->layout_stamp, "star_0.png");
	evas_object_size_hint_weight_set(ad->stamp_star, EVAS_HINT_EXPAND, 0.2);
	evas_object_size_hint_align_set(ad->stamp_star, EVAS_HINT_FILL,
	EVAS_HINT_FILL);
	evas_object_show(ad->stamp_star);
	elm_box_pack_end(ad->layout_stamp, ad->stamp_star);

	ad->btn_back3 = elm_button_add(ad->layout_stamp);
	elm_object_text_set(ad->btn_back3, "메인으로");
	evas_object_size_hint_weight_set(ad->btn_back3, EVAS_HINT_EXPAND, 0.1);
	evas_object_size_hint_align_set(ad->btn_back3, EVAS_HINT_FILL, 0.5);
	evas_object_smart_callback_add(ad->btn_back3, "clicked", btn_clicked_cb,
			ad);
	evas_object_show(ad->btn_back3);
	elm_box_pack_end(ad->layout_stamp, ad->btn_back3);
	evas_object_name_set(ad->btn_back3, "btn_back3");

	// * Stats Labels *
	Evas_Object *stat_label = elm_label_add(ad->layout_stats);
	elm_label_wrap_width_set(stat_label, 400);
	elm_object_text_set(stat_label,
			"<align=center><font_style=bold><font_size=50>통 계</font_size></font_style></align>");
	evas_object_show(stat_label);
	elm_grid_pack(ad->layout_stats, stat_label, 200, 80, 100, 50);

	ad->stat_e = evas_object_evas_get(ad->layout_stats);

	ad->rect1 = evas_object_rectangle_add(ad->stat_e);
	evas_object_color_set(ad->rect1, 0, 255, 0, 255);
	evas_object_show(ad->rect1);
	elm_grid_pack(ad->layout_stats, ad->rect1, chart_x[0],
			400 - 40 * population[0], 32, 200 + 40 * population[0]);

	ad->rect2 = evas_object_rectangle_add(ad->stat_e);
	evas_object_color_set(ad->rect2, 0, 255, 0, 255);
	evas_object_show(ad->rect2);
	elm_grid_pack(ad->layout_stats, ad->rect2, chart_x[1],
			400 - 40 * population[1], 32, 200 + 40 * population[1]);

	ad->rect3 = evas_object_rectangle_add(ad->stat_e);
	evas_object_color_set(ad->rect3, 0, 255, 0, 255);
	evas_object_show(ad->rect3);
	elm_grid_pack(ad->layout_stats, ad->rect3, chart_x[2],
			400 - 40 * population[2], 32, 200 + 40 * population[2]);

	ad->rect4 = evas_object_rectangle_add(ad->stat_e);
	evas_object_color_set(ad->rect4, 0, 255, 0, 255);
	evas_object_show(ad->rect4);
	elm_grid_pack(ad->layout_stats, ad->rect4, chart_x[3],
			400 - 40 * population[3], 32, 200 + 40 * population[3]);

	ad->rect5 = evas_object_rectangle_add(ad->stat_e);
	evas_object_color_set(ad->rect5, 0, 255, 0, 255);
	evas_object_show(ad->rect5);
	elm_grid_pack(ad->layout_stats, ad->rect5, chart_x[4],
			400 - 40 * population[4], 32, 200 + 40 * population[4]);

	ad->rect6 = evas_object_rectangle_add(ad->stat_e);
	evas_object_color_set(ad->rect6, 0, 255, 0, 255);
	evas_object_show(ad->rect6);
	elm_grid_pack(ad->layout_stats, ad->rect6, chart_x[5],
			400 - 40 * population[5], 32, 200 + 40 * population[5]);

	ad->rect7 = evas_object_rectangle_add(ad->stat_e);
	evas_object_color_set(ad->rect7, 0, 255, 0, 255);
	evas_object_show(ad->rect7);
	elm_grid_pack(ad->layout_stats, ad->rect7, chart_x[6],
			400 - 40 * population[6], 32, 200 + 40 * population[6]);

	ad->btn_refresh4 = elm_button_add(ad->layout_stats);
	elm_object_text_set(ad->btn_refresh4, "refresh");
	evas_object_smart_callback_add(ad->btn_refresh4, "clicked",
			stat_refresh_clicked_cb, ad);
	evas_object_show(ad->btn_refresh4);
	elm_grid_pack(ad->layout_stats, ad->btn_refresh4, 15, 30, 150, 40);
	evas_object_name_set(ad->btn_refresh4, "btn_refresh4");

	Evas_Object *day_label = elm_label_add(ad->layout_stats);
	elm_label_wrap_width_set(day_label, 416);
	elm_object_text_set(day_label,
			"<font_style=bold><font_size=30>월      화     수     목      금     토     일</font_size></font_style>");
	evas_object_show(day_label);
	elm_grid_pack(ad->layout_stats, day_label, 32, 610, 416, 60);

	ad->btn_back4 = elm_button_add(ad->layout_stats);
	elm_object_text_set(ad->btn_back4, "메인으로");
	evas_object_smart_callback_add(ad->btn_back4, "clicked", btn_clicked_cb,
			ad);
	evas_object_show(ad->btn_back4);
	elm_grid_pack(ad->layout_stats, ad->btn_back4, 0, 740, 480, 40);
	evas_object_name_set(ad->btn_back4, "btn_back4");

	/* Show window after base gui is set up */
	evas_object_show(ad->win);
	evas_object_show(ad->layout_main);

}

static bool app_create(void *data) {
	/* Hook to take necessary actions before main event loop starts
	 Initialize UI resources and application's data
	 If this function returns true, the main loop of application starts
	 If this function returns false, the application is terminated */
	appdata_s *ad = data;

	//Create a thread for BLE discovery
	if (!pthread_create(&thread_id, NULL, thread_run, ad))
		perror("pthread_create!\n");

	create_base_gui(ad);

	return true;
}

static void app_control(app_control_h app_control, void *data) {
	/* Handle the launch request. */
}

static void app_pause(void *data) {
	/* Take necessary actions when application becomes invisible. */
}

static void app_resume(void *data) {
	/* Take necessary actions when application becomes visible. */
}

static void app_terminate(void *data) {
	/* Release all resources. */
}

static void ui_app_lang_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE,
			&locale);
	elm_language_set(locale);
	free(locale);
	return;
}

static void ui_app_orient_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void ui_app_region_changed(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void ui_app_low_battery(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_BATTERY*/
}

static void ui_app_low_memory(app_event_info_h event_info, void *user_data) {
	/*APP_EVENT_LOW_MEMORY*/
}

int main(int argc, char *argv[]) {
	appdata_s ad = { 0, };
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = { 0, };
	app_event_handler_h handlers[5] = { NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY],
			APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY],
			APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED],
			APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED],
			APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED],
			APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "ui_app_main() is failed. err = %d",
				ret);
	}

	return ret;
}

