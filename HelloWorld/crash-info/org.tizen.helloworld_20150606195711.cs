S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: helloworld
PID: 9876
Date: 2015-06-06 19:57:11+0900
Executable File Path: /opt/usr/apps/org.tizen.helloworld/bin/helloworld
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb4d9213e

Register Information
r0   = 0xb4d92132, r1   = 0x84b0ea9c
r2   = 0x00203a20, r3   = 0x8becb0b8
r4   = 0xb4d9b83c, r5   = 0xb4d91d6f
r6   = 0xb4d92df6, r7   = 0xbeee3b00
r8   = 0xb4d9b848, r9   = 0xb4d9b154
r10  = 0xb31646a0, fp   = 0x00000000
ip   = 0xffff7bab, sp   = 0xbeee3ad8
lr   = 0xb4d91615, pc   = 0xb4d91624
cpsr = 0x60000030

Memory Information
MemTotal:   730748 KB
MemFree:    161988 KB
Buffers:     40456 KB
Cached:     204712 KB
VmPeak:      95868 KB
VmSize:      95864 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21460 KB
VmRSS:       21456 KB
VmData:      42720 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       24112 KB
VmPTE:          68 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 9876 TID = 9876
9876 9878 9879 

Maps Information
b3215000 b3218000 r-xp /usr/lib/evas/modules/loaders/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
b3220000 b3222000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3401000 b3c00000 rwxp [stack:9879]
b3d16000 b3d17000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3d1f000 b3d26000 r-xp /usr/lib/libfeedback.so.0.1.4
b3d46000 b3d47000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3d4f000 b3d50000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3d58000 b3d6f000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3d7b000 b3d7f000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3d88000 b3d92000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3d9c000 b459b000 rwxp [stack:9878]
b48cc000 b4996000 r-xp /usr/lib/libCOREGL.so.4.0
b49a7000 b49ac000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b49b4000 b49b6000 r-xp /usr/lib/libiniparser.so.0
b49c0000 b49c2000 r-xp /usr/lib/libdri2.so.0.0.0
b49ca000 b49d1000 r-xp /usr/lib/libtbm.so.1.0.0
b49d9000 b49e0000 r-xp /usr/lib/libdrm.so.2.4.0
b49e9000 b49f1000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b49f9000 b49fe000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4a06000 b4a0b000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4a14000 b4a15000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4a1e000 b4a36000 r-xp /usr/lib/libpng12.so.0.50.0
b4a3e000 b4a41000 r-xp /usr/lib/libEGL.so.1.4
b4a49000 b4a57000 r-xp /usr/lib/libGLESv2.so.2.0
b4a60000 b4a64000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4a6d000 b4a76000 r-xp /usr/lib/libmdm-common.so.1.0.45
b4a7e000 b4bbd000 r-xp /usr/lib/libicui18n.so.51.1
b4bcd000 b4bd5000 r-xp /usr/lib/libui-extension.so.0.1.0
b4bd6000 b4bd9000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b4be1000 b4be4000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b4bec000 b4ca2000 r-xp /usr/lib/libcairo.so.2.11200.14
b4cad000 b4cbf000 r-xp /usr/lib/libtts.so
b4cc7000 b4cda000 r-xp /usr/lib/libmdm.so.1.0.88
b4ce2000 b4ce5000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b4ced000 b4d03000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4d0b000 b4d3a000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b4d43000 b4d4a000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b4d53000 b4d70000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.52
b4d7a000 b4d84000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b4d8d000 b4d93000 r-xp /opt/usr/apps/org.tizen.helloworld/bin/helloworld
b4d9c000 b4da6000 r-xp /lib/libnss_files-2.13.so
b4daf000 b4dc1000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4dc9000 b4ddf000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4de7000 b4eb5000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4ecc000 b4ef0000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4ef9000 b4eff000 r-xp /usr/lib/libappsvc.so.0.1.0
b4f07000 b4f15000 r-xp /usr/lib/libail.so.0.1.0
b4f1d000 b4f1f000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.3
b4f28000 b4f2d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b4f36000 b4f38000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4f40000 b4f41000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4f4a000 b4f4e000 r-xp /usr/lib/libogg.so.0.7.1
b4f56000 b4f78000 r-xp /usr/lib/libvorbis.so.0.4.3
b4f80000 b5064000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b5078000 b50a9000 r-xp /usr/lib/libFLAC.so.8.2.0
b5a43000 b5ad7000 r-xp /usr/lib/libstdc++.so.6.0.16
b5aea000 b5aec000 r-xp /usr/lib/libXau.so.6.0.0
b5af4000 b5afe000 r-xp /usr/lib/libspdy.so.0.0.0
b5b07000 b5b53000 r-xp /usr/lib/libssl.so.1.0.0
b5b60000 b5b8e000 r-xp /usr/lib/libidn.so.11.5.44
b5b96000 b5ba0000 r-xp /usr/lib/libcares.so.2.1.0
b5ba8000 b5bc9000 r-xp /usr/lib/libexif.so.12.3.3
b5bdc000 b5c21000 r-xp /usr/lib/libsndfile.so.1.0.25
b5c2f000 b5c45000 r-xp /lib/libexpat.so.1.5.2
b5c4e000 b5d33000 r-xp /usr/lib/libicuuc.so.51.1
b5d48000 b5d7c000 r-xp /usr/lib/libicule.so.51.1
b5d85000 b5d98000 r-xp /usr/lib/libxcb.so.1.1.0
b5da0000 b5ddd000 r-xp /usr/lib/libcurl.so.4.3.0
b5de6000 b5def000 r-xp /usr/lib/libethumb.so.1.7.99
b5df8000 b5dfa000 r-xp /usr/lib/libctxdata.so.0.0.0
b5e02000 b5e0f000 r-xp /usr/lib/libremix.so.0.0.0
b5e17000 b5e18000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e20000 b5e37000 r-xp /usr/lib/liblua-5.1.so
b5e40000 b5e47000 r-xp /usr/lib/libembryo.so.1.7.99
b5e4f000 b5e72000 r-xp /usr/lib/libjpeg.so.8.0.2
b5e8a000 b5ee0000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5eed000 b5f40000 r-xp /usr/lib/libfreetype.so.6.8.1
b5f4b000 b5f73000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5f74000 b5fba000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5fc3000 b5fd6000 r-xp /usr/lib/libfribidi.so.0.3.1
b5fde000 b5fe1000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5fe9000 b5fed000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b5ff5000 b5ffa000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6003000 b600d000 r-xp /usr/lib/libXext.so.6.4.0
b6015000 b60f6000 r-xp /usr/lib/libX11.so.6.3.0
b6101000 b6104000 r-xp /usr/lib/libXtst.so.6.1.0
b610c000 b6112000 r-xp /usr/lib/libXrender.so.1.3.0
b611a000 b611f000 r-xp /usr/lib/libXrandr.so.2.2.0
b6127000 b6128000 r-xp /usr/lib/libXinerama.so.1.0.0
b6131000 b6139000 r-xp /usr/lib/libXi.so.6.1.0
b613a000 b613d000 r-xp /usr/lib/libXfixes.so.3.1.0
b6145000 b6147000 r-xp /usr/lib/libXgesture.so.7.0.0
b614f000 b6151000 r-xp /usr/lib/libXcomposite.so.1.0.0
b6159000 b615a000 r-xp /usr/lib/libXdamage.so.1.1.0
b6163000 b6169000 r-xp /usr/lib/libXcursor.so.1.0.2
b6172000 b618b000 r-xp /usr/lib/libecore_con.so.1.7.99
b6195000 b619b000 r-xp /usr/lib/libecore_imf.so.1.7.99
b61a3000 b61ab000 r-xp /usr/lib/libethumb_client.so.1.7.99
b61b3000 b61bc000 r-xp /usr/lib/libedbus.so.1.7.99
b61c4000 b6221000 r-xp /usr/lib/libedje.so.1.7.99
b622a000 b623b000 r-xp /usr/lib/libecore_input.so.1.7.99
b6243000 b6248000 r-xp /usr/lib/libecore_file.so.1.7.99
b6250000 b6269000 r-xp /usr/lib/libeet.so.1.7.99
b627a000 b627e000 r-xp /usr/lib/libappcore-common.so.1.1
b6286000 b634d000 r-xp /usr/lib/libevas.so.1.7.99
b6372000 b6393000 r-xp /usr/lib/libecore_evas.so.1.7.99
b639c000 b63cb000 r-xp /usr/lib/libecore_x.so.1.7.99
b63d5000 b650c000 r-xp /usr/lib/libelementary.so.1.7.99
b6522000 b6523000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b652b000 b652f000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.3
b653a000 b653d000 r-xp /lib/libgpg-error.so.0.5.0
b6545000 b659d000 r-xp /usr/lib/libgcrypt.so.11.5.3
b65a7000 b65d3000 r-xp /usr/lib/libsystemd.so.0.0.1
b65dc000 b65de000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b65e7000 b66b2000 r-xp /usr/lib/libxml2.so.2.7.8
b66c0000 b66d0000 r-xp /lib/libresolv-2.13.so
b66d4000 b66ea000 r-xp /lib/libz.so.1.2.5
b66f2000 b66f4000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b66fc000 b6701000 r-xp /usr/lib/libffi.so.5.0.10
b670a000 b670b000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6713000 b6716000 r-xp /lib/libattr.so.1.1.0
b671e000 b6721000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b6729000 b6730000 r-xp /usr/lib/libvconf.so.0.2.45
b6739000 b68e0000 r-xp /usr/lib/libcrypto.so.1.0.0
b6902000 b6918000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6920000 b6989000 r-xp /lib/libm-2.13.so
b6992000 b69d2000 r-xp /usr/lib/libeina.so.1.7.99
b69db000 b6a0f000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6a18000 b6aec000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6af8000 b6afd000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6b06000 b6b0c000 r-xp /lib/librt-2.13.so
b6b15000 b6b1c000 r-xp /lib/libcrypt-2.13.so
b6b4c000 b6b4f000 r-xp /lib/libcap.so.2.21
b6b57000 b6b59000 r-xp /usr/lib/libiri.so
b6b61000 b6b80000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b88000 b6b9e000 r-xp /usr/lib/libecore.so.1.7.99
b6bb4000 b6bb9000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bc2000 b6bd9000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6be2000 b6bed000 r-xp /lib/libunwind.so.8.0.1
b6c1a000 b6d35000 r-xp /lib/libc-2.13.so
b6d43000 b6d4b000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d53000 b6d7d000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6d86000 b6d89000 r-xp /usr/lib/libbundle.so.0.1.22
b6d91000 b6d93000 r-xp /lib/libdl-2.13.so
b6d9c000 b6d9f000 r-xp /usr/lib/libsmack.so.1.0.0
b6da7000 b6e77000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6e78000 b6edd000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6ee7000 b6ef9000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f01000 b6f15000 r-xp /lib/libpthread-2.13.so
b6f20000 b6f22000 r-xp /usr/lib/libdlog.so.0.0.0
b6f2a000 b6f35000 r-xp /usr/lib/libaul.so.0.1.0
b6f47000 b6f4a000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f54000 b6f58000 r-xp /usr/lib/libsys-assert.so
b6f61000 b6f7e000 r-xp /lib/ld-2.13.so
b6f87000 b6f8c000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b769e000 b76c8000 rw-p [heap]
b76c8000 b7834000 rw-p [heap]
beec4000 beee5000 rwxp [stack]
beec4000 beee5000 rwxp [stack]
End of Maps Information

Callstack Information (PID:9876)
Call Stack Count: 1
 0: list_it_image_text_cb1 + 0x207 (0xb4d91624) [/opt/usr/apps/org.tizen.helloworld/bin/helloworld] + 0x4624
End of Call Stack

Package Information
Package Name: org.tizen.helloworld
Package ID : org.tizen.helloworld
Version: 1.0.0
Package Type: rpm
App Name: helloworld
App ID: org.tizen.helloworld
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
 0 25 36"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 331 5 28 25"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 359 5 28 25"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 238 595 5 28 25"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 239 623 5 28 25"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 651 5 28 25"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 679 5 28 25"
06-06 19:56:47.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
06-06 19:56:48.277+0900 I/Tizen::Net::Wifi( 1108): (1072) > _WifiService is not registered.
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 331 5 28 25"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 359 5 28 25"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 238 595 5 28 25"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 239 623 5 28 25"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 651 5 28 25"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 679 5 28 25"
06-06 19:56:48.277+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
06-06 19:56:50.287+0900 I/Tizen::Net::Wifi( 1108): (1072) > _WifiService is not registered.
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 331 5 28 25"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 359 5 28 25"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 238 595 5 28 25"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 239 623 5 28 25"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 651 5 28 25"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 679 5 28 25"
06-06 19:56:50.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
06-06 19:56:51.287+0900 I/Tizen::Net::Wifi( 1108): (1072) > _WifiService is not registered.
06-06 19:56:51.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 19:56:51.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 19:56:51.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 19:56:51.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 19:56:51.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 19:56:51.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
06-06 19:56:51.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 331 5 28 25"
06-06 19:56:51.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 359 5 28 25"
06-06 19:56:51.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
06-06 19:56:51.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 19:56:51.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 19:56:51.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 19:56:51.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 19:56:51.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 19:56:51.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 238 595 5 28 25"
06-06 19:56:51.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 239 623 5 28 25"
06-06 19:56:51.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 651 5 28 25"
06-06 19:56:51.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 679 5 28 25"
06-06 19:56:51.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
06-06 19:56:54.287+0900 I/Tizen::Net::Wifi( 1108): (1072) > _WifiService is not registered.
06-06 19:56:54.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 19:56:54.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 19:56:54.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 19:56:54.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 19:56:54.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 19:56:54.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
06-06 19:56:54.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 331 5 28 25"
06-06 19:56:54.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 359 5 28 25"
06-06 19:56:54.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
06-06 19:56:54.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 19:56:54.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 19:56:54.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 19:56:54.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 19:56:54.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 19:56:54.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 238 595 5 28 25"
06-06 19:56:54.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 239 623 5 28 25"
06-06 19:56:54.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 651 5 28 25"
06-06 19:56:54.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 679 5 28 25"
06-06 19:56:54.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
06-06 19:56:57.287+0900 I/Tizen::Net::Wifi( 1108): (1072) > _WifiService is not registered.
06-06 19:56:57.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 19:56:57.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 19:56:57.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 19:56:57.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 19:56:57.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 19:56:57.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
06-06 19:56:57.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 331 5 28 25"
06-06 19:56:57.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 359 5 28 25"
06-06 19:56:57.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
06-06 19:56:57.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 19:56:57.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 19:56:57.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 19:56:57.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 19:56:57.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 19:56:57.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 238 595 5 28 25"
06-06 19:56:57.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 239 623 5 28 25"
06-06 19:56:57.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 651 5 28 25"
06-06 19:56:57.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 679 5 28 25"
06-06 19:56:57.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
06-06 19:56:58.287+0900 I/Tizen::Net::Wifi( 1108): (1072) > _WifiService is not registered.
06-06 19:56:58.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 19:56:58.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 19:56:58.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 19:56:58.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 19:56:58.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 19:56:58.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
06-06 19:56:58.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 331 5 28 25"
06-06 19:56:58.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 359 5 28 25"
06-06 19:56:58.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
06-06 19:56:58.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 19:56:58.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 19:56:58.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 19:56:58.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 19:56:58.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 19:56:58.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 238 595 5 28 25"
06-06 19:56:58.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 239 623 5 28 25"
06-06 19:56:58.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 651 5 28 25"
06-06 19:56:58.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 679 5 28 25"
06-06 19:56:58.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
06-06 19:56:59.377+0900 I/Tizen::Net::Wifi( 1108): (1072) > _WifiService is not registered.
06-06 19:56:59.387+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 19:56:59.387+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 19:56:59.387+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 19:56:59.387+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 19:56:59.387+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 19:56:59.387+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
06-06 19:56:59.387+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 331 5 28 25"
06-06 19:56:59.387+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 359 5 28 25"
06-06 19:56:59.387+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
06-06 19:56:59.397+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 19:56:59.397+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 19:56:59.397+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 19:56:59.397+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 19:56:59.397+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 19:56:59.397+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 238 595 5 28 25"
06-06 19:56:59.397+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 239 623 5 28 25"
06-06 19:56:59.397+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 651 5 28 25"
06-06 19:56:59.397+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 679 5 28 25"
06-06 19:56:59.397+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
06-06 19:57:00.277+0900 I/Tizen::Net::Wifi( 1108): (1072) > _WifiService is not registered.
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 331 5 28 25"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 359 5 28 25"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 238 595 5 28 25"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 239 623 5 28 25"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 651 5 28 25"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 679 5 28 25"
06-06 19:57:00.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
06-06 19:57:01.287+0900 I/Tizen::Net::Wifi( 1108): (1072) > _WifiService is not registered.
06-06 19:57:01.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 19:57:01.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 19:57:01.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 19:57:01.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 19:57:01.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 19:57:01.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
06-06 19:57:01.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 331 5 28 25"
06-06 19:57:01.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 359 5 28 25"
06-06 19:57:01.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
06-06 19:57:01.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 19:57:01.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 19:57:01.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 19:57:01.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 19:57:01.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 19:57:01.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 238 595 5 28 25"
06-06 19:57:01.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 239 623 5 28 25"
06-06 19:57:01.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 651 5 28 25"
06-06 19:57:01.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 679 5 28 25"
06-06 19:57:01.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
06-06 19:57:01.897+0900 E/PKGMGR  ( 9797): pkgmgr-internal.c: _get_type_from_zip(634) > can not access to [org.tizen.helloworld]
06-06 19:57:01.897+0900 E/PKGMGR_SERVER( 9797): pkgmgr-server.c: __get_type_from_msg(283) > [0;31m[__get_type_from_msg(): 283](pkgtype == NULL) pkgtype is null for org.tizen.helloworld 
06-06 19:57:01.897+0900 E/PKGMGR_SERVER( 9797): [0;m
06-06 19:57:02.077+0900 I/Tizen::App( 1020): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.helloworld, key: start, val: update
06-06 19:57:02.077+0900 I/Tizen::App( 1020): (1584) > Package = [org.tizen.helloworld], Key = [start], Value = [update], install = [1]
06-06 19:57:02.087+0900 W/AUL_AMD (  449): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(580) > __amd_pkgmgrinfo_start_handler
06-06 19:57:02.097+0900 I/Tizen::App( 1020): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.helloworld, key: install_percent, val: 30
06-06 19:57:02.097+0900 I/Tizen::App( 1020): (119) > InstallationInProgress [30]
06-06 19:57:02.097+0900 I/Tizen::App( 1020): (1584) > Package = [org.tizen.helloworld], Key = [install_percent], Value = [30], install = [1]
06-06 19:57:02.277+0900 I/Tizen::Net::Wifi( 1108): (1072) > _WifiService is not registered.
06-06 19:57:02.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 19:57:02.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 19:57:02.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 19:57:02.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 19:57:02.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 19:57:02.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
06-06 19:57:02.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 331 5 28 25"
06-06 19:57:02.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 359 5 28 25"
06-06 19:57:02.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
06-06 19:57:02.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 19:57:02.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 19:57:02.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 19:57:02.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 19:57:02.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 19:57:02.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 238 595 5 28 25"
06-06 19:57:02.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 239 623 5 28 25"
06-06 19:57:02.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 651 5 28 25"
06-06 19:57:02.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 679 5 28 25"
06-06 19:57:02.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
06-06 19:57:03.087+0900 E/PKGMGR_CERT( 9798): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
06-06 19:57:03.097+0900 E/PKGMGR_CERT( 9798): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 1 110
06-06 19:57:03.097+0900 E/PKGMGR_CERT( 9798): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 2 110
06-06 19:57:03.097+0900 I/Tizen::App( 1020): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.helloworld, key: install_percent, val: 60
06-06 19:57:03.097+0900 I/Tizen::App( 1020): (119) > InstallationInProgress [60]
06-06 19:57:03.097+0900 I/Tizen::App( 1020): (1584) > Package = [org.tizen.helloworld], Key = [install_percent], Value = [60], install = [1]
06-06 19:57:03.097+0900 E/PKGMGR_CERT( 9798): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 21 6
06-06 19:57:03.097+0900 E/PKGMGR_CERT( 9798): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 22 23
06-06 19:57:03.097+0900 E/PKGMGR_CERT( 9798): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 23 23
06-06 19:57:03.097+0900 E/PKGMGR_CERT( 9798): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 33 4
06-06 19:57:03.117+0900 E/PKGMGR_CERT( 9798): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
06-06 19:57:03.117+0900 E/rpm-installer( 9798): coretpk-installer.c: _coretpk_installer_make_directory(1784) > mkdir failed. appdir=[/usr/apps/org.tizen.helloworld/shared], errno=[2][No such file or directory]
06-06 19:57:03.117+0900 E/rpm-installer( 9798): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/usr/apps/org.tizen.helloworld/shared]
06-06 19:57:03.117+0900 E/rpm-installer( 9798): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/opt/usr/apps/org.tizen.helloworld/shared/data]
06-06 19:57:03.117+0900 E/rpm-installer( 9798): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/usr/apps/org.tizen.helloworld/shared/res]
06-06 19:57:03.117+0900 E/rpm-installer( 9798): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.helloworld/tizen-manifest.xml]
06-06 19:57:03.117+0900 E/rpm-installer( 9798): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.helloworld/author-signature.xml]
06-06 19:57:03.117+0900 E/rpm-installer( 9798): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.helloworld/signature1.xml]
06-06 19:57:03.117+0900 E/rpm-installer( 9798): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/share/packages/org.tizen.helloworld.xml]
06-06 19:57:03.657+0900 E/rpm-installer( 9798): coretpk-installer.c: _coretpk_installer_get_smack_label_access(964) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.helloworld/shared/data]))
06-06 19:57:05.807+0900 E/PKGMGR_INFO( 9798): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
06-06 19:57:05.807+0900 E/PKGMGR_INSTALLER( 9798): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
06-06 19:57:05.827+0900 E/cluster-home(  592): mainmenu-package-manager.cpp: OnClientListenCb(535) >  #Step 1
06-06 19:57:05.827+0900 E/cluster-home(  592): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 2
06-06 19:57:05.827+0900 E/cluster-home(  592): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
06-06 19:57:05.827+0900 I/Tizen::App( 1020): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.helloworld, key: install_percent, val: 100
06-06 19:57:05.827+0900 I/Tizen::App( 1020): (119) > InstallationInProgress [100]
06-06 19:57:05.827+0900 I/Tizen::App( 1020): (1584) > Package = [org.tizen.helloworld], Key = [install_percent], Value = [100], install = [96]
06-06 19:57:05.827+0900 I/Tizen::App( 1020): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.helloworld, key: end, val: ok
06-06 19:57:05.827+0900 I/Tizen::App( 1020): (78) > Installation is Completed. [Package = org.tizen.helloworld]
06-06 19:57:05.827+0900 I/Tizen::App( 1020): (663) > Enter. package(org.tizen.helloworld), installationResult(0)
06-06 19:57:05.847+0900 I/Tizen::App( 1020): (1360) > package(org.tizen.helloworld), version(1.0.0), type(rpm), displayName(helloworld), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.helloworld), storeClient(), appRootPath(/opt/usr/apps/org.tizen.helloworld)
06-06 19:57:05.867+0900 I/Tizen::App( 1020): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.helloworld]
06-06 19:57:05.887+0900 E/cluster-home(  592): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.helloworld]
06-06 19:57:05.887+0900 E/cluster-home(  592): mainmenu-package-manager.cpp: _GetAppIds(365) >  ##### [org.tizen.helloworld]
06-06 19:57:05.887+0900 E/cluster-home(  592): mainmenu-package-manager.cpp: _GetAppIds(369) >  END
06-06 19:57:05.887+0900 E/cluster-home(  592): mainmenu-package-manager.cpp: _DoPkgJob(448) >  #Step 3 size[1]
06-06 19:57:05.887+0900 E/cluster-home(  592): mainmenu-package-manager.cpp: _DoPkgJob(452) >  appId[org.tizen.helloworld]
06-06 19:57:05.897+0900 E/cluster-home(  592): mainmenu-package-manager.cpp: _GetAppInfo(941) >  AppId[org.tizen.helloworld] Name[helloworld] Icon[/opt/usr/apps/org.tizen.helloworld/shared/res/Koala.png] enable[1] system[0]
06-06 19:57:05.907+0900 I/Tizen::App( 1020): (416) > appName = [helloworld]
06-06 19:57:05.907+0900 I/Tizen::App( 1020): (509) > exe = [/opt/usr/apps/org.tizen.helloworld/bin/helloworld], displayName = [helloworld], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-06 19:57:05.907+0900 E/PKGMGR_INFO( 1020): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-06 19:57:05.907+0900 E/cluster-home(  592): mainmenu-package-manager.cpp: GetAppInfo(595) >  Find a App Info AppId[org.tizen.helloworld] Name[helloworld] Icon[/opt/usr/apps/org.tizen.helloworld/shared/res/Koala.png] enable[1] system[0]
06-06 19:57:05.907+0900 I/Tizen::App( 1020): (675) > Application count(1) in this package
06-06 19:57:05.907+0900 I/Tizen::App( 1020): (855) > Enter.
06-06 19:57:05.917+0900 I/Tizen::App( 1020): (695) > Exit.
06-06 19:57:05.917+0900 I/Tizen::App( 1020): (1584) > Package = [org.tizen.helloworld], Key = [end], Value = [ok], install = [96]
06-06 19:57:05.927+0900 I/Tizen::App( 1020): (416) > appName = [helloworld]
06-06 19:57:05.927+0900 I/Tizen::App( 1020): (509) > exe = [/opt/usr/apps/org.tizen.helloworld/bin/helloworld], displayName = [helloworld], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-06 19:57:05.927+0900 I/Tizen::App( 1020): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.helloworld.info]
06-06 19:57:05.927+0900 I/Tizen::App( 1020): (131) > Enter
06-06 19:57:05.937+0900 I/Tizen::App( 1020): (137) > org.tizen.helloworld does not have launch condition
06-06 19:57:05.937+0900 I/Tizen::App( 1020): (898) > Exit.
06-06 19:57:08.097+0900 W/AUL_AMD (  449): amd_request.c: __request_handler(601) > __request_handler: 0
06-06 19:57:08.107+0900 I/AUL     (  449): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
06-06 19:57:08.117+0900 I/AUL     (  449): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
06-06 19:57:08.117+0900 E/AUL_AMD (  449): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
06-06 19:57:08.207+0900 I/CAPI_APPFW_APPLICATION( 9876): app_main.c: ui_app_main(699) > app_efl_main
06-06 19:57:08.247+0900 E/RESOURCED(  756): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 434
06-06 19:57:08.247+0900 I/UXT     ( 9876): uxt_object_manager.cpp: on_initialized(287) > Initialized.
06-06 19:57:08.257+0900 I/Tizen::App( 1068): (733) > Finished invoking application event listener for org.tizen.helloworld, 9876.
06-06 19:57:08.257+0900 I/Tizen::App( 1020): (499) > LaunchedApp(org.tizen.helloworld)
06-06 19:57:08.257+0900 I/Tizen::App( 1020): (733) > Finished invoking application event listener for org.tizen.helloworld, 9876.
06-06 19:57:08.287+0900 I/Tizen::Net::Wifi( 1108): (1072) > _WifiService is not registered.
06-06 19:57:08.287+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 19:57:08.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 19:57:08.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 19:57:08.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 19:57:08.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 19:57:08.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
06-06 19:57:08.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 331 5 28 25"
06-06 19:57:08.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 359 5 28 25"
06-06 19:57:08.297+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
06-06 19:57:08.307+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 19:57:08.307+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 19:57:08.307+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 19:57:08.307+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 19:57:08.307+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 19:57:08.307+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 238 595 5 28 25"
06-06 19:57:08.307+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 239 623 5 28 25"
06-06 19:57:08.307+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 651 5 28 25"
06-06 19:57:08.307+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 679 5 28 25"
06-06 19:57:08.307+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
06-06 19:57:08.317+0900 I/CAPI_APPFW_APPLICATION( 9876): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
06-06 19:57:08.337+0900 I/APAMS   ( 9876): helloworld.c: blue_setting(1050) > [blue_setting] BLE discovering starts.
06-06 19:57:08.447+0900 I/APAMS   ( 9876): helloworld.c: blue_setting(1083) > [blue_setting] BT was already enabled.
06-06 19:57:08.527+0900 E/EFL     ( 9876): evas_main<9876> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
06-06 19:57:08.537+0900 E/EFL     ( 9876): evas_main<9876> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
06-06 19:57:08.627+0900 E/EFL     ( 9876): evas_main<9876> evas_object_main.c:1322 evas_object_color_set() Evas only handles pre multiplied colors!
06-06 19:57:08.627+0900 E/EFL     ( 9876): evas_main<9876> evas_object_main.c:1327 evas_object_color_set() Evas only handles pre multiplied colors!
06-06 19:57:08.627+0900 E/EFL     ( 9876): evas_main<9876> evas_object_main.c:1317 evas_object_color_set() Evas only handles pre multiplied colors!
06-06 19:57:08.627+0900 E/EFL     ( 9876): evas_main<9876> evas_object_main.c:1317 evas_object_color_set() Evas only handles pre multiplied colors!
06-06 19:57:08.717+0900 I/CAPI_APPFW_APPLICATION( 9876): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-06 19:57:08.727+0900 I/APP_CORE( 9876): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
06-06 19:57:08.727+0900 I/APP_CORE( 9876): appcore-efl.c: __do_app(511) > [APP 9876] Initial Launching, call the resume_cb
06-06 19:57:08.727+0900 I/CAPI_APPFW_APPLICATION( 9876): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-06 19:57:08.757+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=9876
06-06 19:57:08.757+0900 W/APP_CORE( 9876): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4600002
06-06 19:57:08.827+0900 I/Tizen::System( 1068): (259) > Active app [org.tizen.], current [com.samsun] 
06-06 19:57:08.827+0900 I/Tizen::Io( 1068): (729) > Entry not found
06-06 19:57:08.837+0900 I/MALI    (  592): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xafe2c820] swap changed from sync to async
06-06 19:57:08.857+0900 I/Tizen::System( 1068): (157) > change brightness system value.
06-06 19:57:08.887+0900 I/CAPI_APPFW_APPLICATION(  592): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-06 19:57:08.887+0900 E/cluster-home(  592): homescreen-main.cpp: app_pause(355) >  app pause
06-06 19:57:08.907+0900 W/AUL_AMD (  449): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-06 19:57:08.907+0900 W/AUL_AMD (  449): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-06 19:57:09.497+0900 I/APAMS   ( 9876): <In the CS of the BLE Thread
06-06 19:57:09.497+0900 E/APAMS   ( 9876): BLE Thread is running... (For 0 sec)
06-06 19:57:09.867+0900 I/APAMS   ( 9876): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 19:57:09.867+0900 I/APAMS   ( 9876): Device Address: 78:A5:04:4F:06:82
06-06 19:57:09.867+0900 I/APAMS   ( 9876): Device RSSI: -69
06-06 19:57:09.867+0900 I/APAMS   ( 9876): howd? trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-69&phoneid=1
06-06 19:57:09.927+0900 I/APAMS   ( 9876): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 19:57:09.927+0900 I/APAMS   ( 9876): Device Address: 78:A5:04:4F:39:58
06-06 19:57:09.927+0900 I/APAMS   ( 9876): Device RSSI: -48
06-06 19:57:09.937+0900 I/APAMS   ( 9876): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-48&phoneid=1
06-06 19:57:10.117+0900 I/APAMS   ( 9876): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 19:57:10.117+0900 I/APAMS   ( 9876): Device Address: 78:A5:04:4F:3A:DC
06-06 19:57:10.117+0900 I/APAMS   ( 9876): Device RSSI: -67
06-06 19:57:10.127+0900 I/APAMS   ( 9876): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-67&phoneid=1
06-06 19:57:10.177+0900 I/APAMS   ( 9876): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 19:57:10.177+0900 I/APAMS   ( 9876): Device Address: 78:A5:04:4F:06:82
06-06 19:57:10.177+0900 I/APAMS   ( 9876): Device RSSI: -61
06-06 19:57:10.187+0900 I/APAMS   ( 9876): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-61&phoneid=1
06-06 19:57:10.227+0900 I/APAMS   ( 9876): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 19:57:10.227+0900 I/APAMS   ( 9876): Device Address: 78:A5:04:4F:4D:9E
06-06 19:57:10.227+0900 I/APAMS   ( 9876): Device RSSI: -72
06-06 19:57:10.227+0900 I/APAMS   ( 9876): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-72&phoneid=1
06-06 19:57:10.307+0900 I/APAMS   ( 9876): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 19:57:10.307+0900 I/Tizen::Net::Wifi( 1108): (1072) > _WifiService is not registered.
06-06 19:57:10.307+0900 I/APAMS   ( 9876): Device Address: 78:A5:04:4F:39:58
06-06 19:57:10.307+0900 I/APAMS   ( 9876): Device RSSI: -55
06-06 19:57:10.317+0900 I/APAMS   ( 9876): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-55&phoneid=1
06-06 19:57:10.317+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 19:57:10.317+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 19:57:10.317+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 19:57:10.317+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 19:57:10.317+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 19:57:10.317+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : more_notify 303 5 28 25"
06-06 19:57:10.327+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 331 5 28 25"
06-06 19:57:10.327+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 359 5 28 25"
06-06 19:57:10.327+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 387 5 28 25"
06-06 19:57:10.327+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 19:57:10.327+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 19:57:10.327+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 19:57:10.327+0900 I/indicator(  497): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 19:57:10.327+0900 I/indicator(  497): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 19:57:10.327+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 238 595 5 28 25"
06-06 19:57:10.327+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 239 623 5 28 25"
06-06 19:57:10.327+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 240 651 5 28 25"
06-06 19:57:10.327+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : 242 679 5 28 25"
06-06 19:57:10.327+0900 I/indicator(  497): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 707 5 28 25"
06-06 19:57:10.497+0900 I/APAMS   ( 9876): <In the CS of the BLE Thread
06-06 19:57:10.497+0900 E/APAMS   ( 9876): BLE Thread is running... (For 1 sec)
06-06 19:57:10.887+0900 I/APAMS   ( 9876): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 19:57:10.887+0900 I/APAMS   ( 9876): Device Address: 78:A5:04:4F:06:82
06-06 19:57:10.887+0900 I/APAMS   ( 9876): Device RSSI: -67
06-06 19:57:10.887+0900 I/APAMS   ( 9876): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-67&phoneid=1
06-06 19:57:11.087+0900 I/APAMS   ( 9876): z0﻿﻿/78:A5:04:4F:39:58/1/78:A5:04:4F:3A:DC/0/78:A5:04:4F:4D:9E/0/78:A5:04:4F:06:82/0/
06-06 19:57:11.087+0900 I/APAMS   ( 9876): z1﻿﻿
06-06 19:57:11.087+0900 I/APAMS   ( 9876): z278:A5:04:4F:39:58
06-06 19:57:11.087+0900 I/APAMS   ( 9876): z3-1216550943
06-06 19:57:11.087+0900 I/APAMS   ( 9876): zz_1_78:A5:04:4F:39:58---1---1
06-06 19:57:11.087+0900 I/APAMS   ( 9876): zz_1_1
06-06 19:57:11.087+0900 I/APAMS   ( 9876): zz_1_
06-06 19:57:11.277+0900 W/AUL_AMD (  449): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-06 19:57:11.277+0900 W/AUL_AMD (  449): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-06 19:57:11.297+0900 I/AUL_PAD (  496): sigchild.h: __launchpad_sig_child(142) > dead_pid = 9876 pgid = 9876
06-06 19:57:11.297+0900 I/AUL_PAD (  496): sigchild.h: __sigchild_action(123) > dead_pid(9876)
06-06 19:57:11.297+0900 I/AUL_PAD (  496): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-06 19:57:11.297+0900 I/AUL_PAD (  496): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-06 19:57:11.337+0900 I/Tizen::System( 1068): (246) > Terminated app [org.tizen.helloworld]
06-06 19:57:11.337+0900 I/Tizen::Io( 1068): (729) > Entry not found
06-06 19:57:11.347+0900 I/Tizen::App( 1020): (243) > App[org.tizen.helloworld] pid[9876] terminate event is forwarded
06-06 19:57:11.347+0900 I/Tizen::System( 1020): (256) > osp.accessorymanager.service provider is found.
06-06 19:57:11.347+0900 I/Tizen::System( 1020): (196) > Accessory Owner is removed [org.tizen.helloworld, 9876, ]
06-06 19:57:11.347+0900 I/Tizen::System( 1020): (256) > osp.system.service provider is found.
06-06 19:57:11.347+0900 I/Tizen::App( 1020): (506) > TerminatedApp(org.tizen.helloworld)
06-06 19:57:11.347+0900 I/Tizen::App( 1020): (512) > Not registered pid(9876)
06-06 19:57:11.347+0900 I/Tizen::App( 1020): (782) > Finished invoking application event listener for org.tizen.helloworld, 9876.
06-06 19:57:11.347+0900 I/AUL_AMD (  449): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 9876
06-06 19:57:11.357+0900 I/Tizen::System( 1068): (157) > change brightness system value.
06-06 19:57:11.357+0900 I/Tizen::App( 1068): (782) > Finished invoking application event listener for org.tizen.helloworld, 9876.
06-06 19:57:11.357+0900 W/PROCESSMGR(  376): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=592
06-06 19:57:11.387+0900 I/CAPI_APPFW_APPLICATION(  592): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-06 19:57:11.387+0900 E/cluster-home(  592): homescreen-main.cpp: app_resume(422) >  app resume
06-06 19:57:11.407+0900 W/CRASH_MANAGER( 9891): worker.c: worker_job(1198) > 110987668656c143358823
