S/W Version Information
Model: Mobile-Emulator
Tizen-Version: 2.3.0
Build-Number: Tizen-2.3.0_Mobile-Emulator_20141226.1803
Build-Date: 2014.12.26 18:03:32

Crash Information
Process Name: helloworld
PID: 23827
Date: 2015-05-28 08:18:54+0900
Executable File Path: /opt/usr/apps/org.tizen.helloworld/bin/helloworld
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0xffffffec

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0xffffffec, esi = 0xb85908c0
ebp = 0xbfead2a8, esp = 0xbfead26c
eax = 0xffffffec, ebx = 0xb6796dc8
ecx = 0x3e72623c, edx = 0xb859ae38
eip = 0xb753cfaf

Memory Information
MemTotal:      124 KB
MemFree:        34 KB
Buffers:        20 KB
Cached:     150844 KB
VmPeak:      75196 KB
VmSize:      75196 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       18332 KB
VmRSS:       18332 KB
VmData:      23604 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       33600 KB
VmPTE:          68 KB
VmSwap:          0 KB

Maps Information
b3b1e000 b3b22000 r-xp /usr/lib/evas/modules/loaders/jpeg/linux-gnu-i686-1.7.99/module.so
b3f08000 b3f09000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b470b000 b470d000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnu-i686-1.7.99/module.so
b470e000 b4732000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b4829000 b482c000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b482d000 b4846000 r-xp /usr/lib/yagl/libEGL.so.1.0
b4847000 b488f000 r-xp /usr/lib/yagl/libGLESv2.so.2.0
b4892000 b48fb000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnu-i686-1.7.99/module.so
b4b01000 b4b04000 r-xp /usr/lib/libdri2.so.0.0.0
b4b05000 b4b0e000 r-xp /usr/lib/libtbm.so.1.0.0
b4b0f000 b4b1a000 r-xp /usr/lib/libdrm.so.2.4.0
b4b1b000 b4b21000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b4b22000 b4b2b000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4b2c000 b4b35000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4b36000 b4b3e000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4b3f000 b4b66000 r-xp /usr/lib/libpng12.so.0.50.0
b4b67000 b4b6d000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4b6e000 b4b72000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b4b73000 b4c96000 r-xp /usr/lib/libcairo.so.2.11200.14
b4c99000 b4cb6000 r-xp /usr/lib/libtts.so
b4cb7000 b4cd9000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4cda000 b4d24000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b4d25000 b4d30000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b4d31000 b4d5a000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.52
b4d5d000 b4d6a000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b4d6b000 b4d76000 r-xp /lib/libnss_files-2.13.so
b4d78000 b4e9a000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4eaa000 b4ee0000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4ee2000 b4efa000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4efb000 b4f06000 r-xp /usr/lib/libminizip.so.1.0.0
b4f07000 b4f29000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4f2a000 b4f2c000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b4f2d000 b4f34000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b4f35000 b4f4d000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b4f4e000 b4f56000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b4f57000 b4f5f000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.4
b4f60000 b4f63000 r-xp /usr/lib/libiniparser.so.0
b4f65000 b4f70000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b4f71000 b4f7a000 r-xp /usr/lib/libappsvc.so.0.1.0
b4f7c000 b4f7e000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4f7f000 b4f84000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.23
b4f85000 b4f8a000 r-xp /opt/usr/apps/org.tizen.helloworld/bin/helloworld
b4f8b000 b4f91000 r-xp /usr/lib/libogg.so.0.7.1
b4f92000 b4fbd000 r-xp /usr/lib/libvorbis.so.0.4.3
b4fbe000 b50a9000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b50b7000 b5103000 r-xp /usr/lib/libFLAC.so.8.2.0
b5104000 b5106000 r-xp /usr/lib/libXau.so.6.0.0
b5107000 b5117000 r-xp /usr/lib/libspdy.so.0.0.0
b5118000 b5177000 r-xp /usr/lib/libssl.so.1.0.0
b517c000 b51ad000 r-xp /usr/lib/libidn.so.11.5.44
b51ae000 b51be000 r-xp /usr/lib/libcares.so.2.1.0
b51bf000 b51e9000 r-xp /usr/lib/libexif.so.12.3.3
b51f5000 b5262000 r-xp /usr/lib/libsndfile.so.1.0.25
b5268000 b528e000 r-xp /lib/libexpat.so.1.5.2
b5290000 b52d6000 r-xp /usr/lib/libicule.so.51.1
b52d8000 b52f8000 r-xp /usr/lib/libxcb.so.1.1.0
b52f9000 b535d000 r-xp /usr/lib/libcurl.so.4.3.0
b535f000 b536b000 r-xp /usr/lib/libethumb.so.1.7.99
b5e09000 b5ee1000 r-xp /usr/lib/libstdc++.so.6.0.16
b5eed000 b5ef0000 r-xp /usr/lib/libctxdata.so.0.0.0
b5ef1000 b5f07000 r-xp /usr/lib/libremix.so.0.0.0
b5f08000 b5f0a000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f0b000 b5f37000 r-xp /usr/lib/liblua-5.1.so
b5f38000 b5f42000 r-xp /usr/lib/libembryo.so.1.7.99
b5f43000 b5f89000 r-xp /usr/lib/libjpeg.so.8.0.2
b5f9a000 b601c000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6021000 b6055000 r-xp /usr/lib/libfontconfig.so.1.5.0
b6057000 b60c3000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b60c4000 b60da000 r-xp /usr/lib/libfribidi.so.0.3.1
b60db000 b615e000 r-xp /usr/lib/libfreetype.so.6.8.1
b6162000 b6165000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b6166000 b616c000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b616d000 b6173000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6175000 b6186000 r-xp /usr/lib/libXext.so.6.4.0
b6187000 b62bb000 r-xp /usr/lib/libX11.so.6.3.0
b62bf000 b62c4000 r-xp /usr/lib/libXtst.so.6.1.0
b62c5000 b62cd000 r-xp /usr/lib/libXrender.so.1.3.0
b62ce000 b62d7000 r-xp /usr/lib/libXrandr.so.2.2.0
b62d8000 b62da000 r-xp /usr/lib/libXinerama.so.1.0.0
b62db000 b62e9000 r-xp /usr/lib/libXi.so.6.1.0
b62ea000 b62ee000 r-xp /usr/lib/libXfixes.so.3.1.0
b62ef000 b62f1000 r-xp /usr/lib/libXgesture.so.7.0.0
b62f2000 b62f4000 r-xp /usr/lib/libXcomposite.so.1.0.0
b62f5000 b62f7000 r-xp /usr/lib/libXdamage.so.1.1.0
b62f8000 b6301000 r-xp /usr/lib/libXcursor.so.1.0.2
b6302000 b632d000 r-xp /usr/lib/libecore_con.so.1.7.99
b632f000 b6337000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6338000 b6343000 r-xp /usr/lib/libethumb_client.so.1.7.99
b6344000 b634a000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b634b000 b636c000 r-xp /usr/lib/libefreet.so.1.7.99
b636e000 b637a000 r-xp /usr/lib/libedbus.so.1.7.99
b637b000 b64da000 r-xp /usr/lib/libicuuc.so.51.1
b64e8000 b66f1000 r-xp /usr/lib/libicui18n.so.51.1
b66fa000 b6796000 r-xp /usr/lib/libedje.so.1.7.99
b6798000 b67a9000 r-xp /usr/lib/libecore_input.so.1.7.99
b67aa000 b67b1000 r-xp /usr/lib/libecore_file.so.1.7.99
b67b2000 b67d8000 r-xp /usr/lib/libeet.so.1.7.99
b67e1000 b690b000 r-xp /usr/lib/libevas.so.1.7.99
b6928000 b695c000 r-xp /usr/lib/libecore_evas.so.1.7.99
b695e000 b69a2000 r-xp /usr/lib/libecore_x.so.1.7.99
b69a4000 b6b9d000 r-xp /usr/lib/libelementary.so.1.7.99
b6bac000 b6baf000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b6bb0000 b6bb6000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6bb7000 b6bbb000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6bbf000 b6bc0000 r-xp /usr/lib/libjournal.so.0.1.0
b6bc1000 b6d09000 r-xp /usr/lib/libxml2.so.2.7.8
b6d10000 b6d23000 r-xp /lib/libresolv-2.13.so
b6d27000 b6d44000 r-xp /lib/libz.so.1.2.5
b6d45000 b6d48000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d49000 b6d4e000 r-xp /usr/lib/libffi.so.5.0.10
b6d4f000 b6d50000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6d52000 b6d56000 r-xp /lib/libattr.so.1.1.0
b6d57000 b6f68000 r-xp /usr/lib/libcrypto.so.1.0.0
b6f83000 b6fa6000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6fa7000 b6fcf000 r-xp /lib/libm-2.13.so
b6fd1000 b702c000 r-xp /usr/lib/libeina.so.1.7.99
b702f000 b7039000 r-xp /usr/lib/libvconf.so.0.2.45
b703a000 b703d000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b703e000 b708c000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b708d000 b71ee000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b71f2000 b71f9000 r-xp /lib/librt-2.13.so
b71fc000 b7201000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b7202000 b721c000 r-xp /lib/libgcc_s-4.6.4.so.1
b721d000 b7225000 r-xp /lib/libcrypt-2.13.so
b724e000 b7252000 r-xp /lib/libcap.so.2.21
b7253000 b7255000 r-xp /usr/lib/libiri.so
b7257000 b7282000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b7283000 b72a3000 r-xp /usr/lib/libecore.so.1.7.99
b72b2000 b72bb000 r-xp /usr/lib/libxdgmime.so.1.1.0
b72bc000 b73df000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b73e0000 b73f3000 r-xp /usr/lib/libail.so.0.1.0
b73f5000 b741a000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b741b000 b7425000 r-xp /lib/libunwind.so.8.0.1
b742f000 b75a0000 r-xp /lib/libc-2.13.so
b75a6000 b75f0000 r-xp /usr/lib/libdbus-1.so.3.7.2
b75f1000 b75f6000 r-xp /usr/lib/libbundle.so.0.1.22
b75f7000 b75fa000 r-xp /lib/libdl-2.13.so
b75fd000 b7602000 r-xp /usr/lib/libsmack.so.1.0.0
b7603000 b76ab000 r-xp /usr/lib/libsqlite3.so.0.8.6
b76ae000 b76c8000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76c9000 b76e0000 r-xp /lib/libpthread-2.13.so
b76e4000 b76e7000 r-xp /usr/lib/libdlog.so.0.0.0
b76e8000 b76f8000 r-xp /usr/lib/libaul.so.0.1.0
b76fc000 b7702000 r-xp /usr/lib/libappcore-common.so.1.1
b7703000 b7708000 r-xp /usr/lib/libappcore-efl.so.1.1
b770a000 b770f000 r-xp /usr/lib/libsys-assert.so
b7712000 b7730000 r-xp /lib/ld-2.13.so
b7730000 b7731000 r-xp [vdso]
b7733000 b773a000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:23827)
Call Stack Count: 8
 0: (0xb753cfaf) [/lib/libc.so.6] + 0x10dfaf
 1: edje_object_part_text_escaped_set + 0x148 (0xb677a8f8) [/usr/lib/libedje.so.1] + 0x808f8
 2: (0xb6a9f04d) [/usr/lib/libelementary.so.1] + 0xfb04d
 3: (0xb6a98b04) [/usr/lib/libelementary.so.1] + 0xf4b04
 4: elm_layout_text_set + 0x90 (0xb6a9e320) [/usr/lib/libelementary.so.1] + 0xfa320
 5: elm_widget_text_part_set + 0x78 (0xb6b0a828) [/usr/lib/libelementary.so.1] + 0x166828
 6: elm_object_part_text_set + 0x2f (0xb6aabf6f) [/usr/lib/libelementary.so.1] + 0x107f6f
 7: app_create + 0x1107 (0xb4f87c97) [/opt/usr/apps/org.tizen.helloworld/bin/helloworld] + 0x2c97
End of Call Stack

Package Information
Package Name: org.tizen.helloworld
Package ID : org.tizen.helloworld
Version: 1.0.0
Package Type: coretpk
App Name: helloworld
App ID: org.tizen.helloworld
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
0900 D/LAUNCH  (23780): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.tizen.helloworld/bin/helloworld:Platform:launchpad:done]
05-28 08:18:29.611+0900 I/CAPI_APPFW_APPLICATION(23780): app_main.c: ui_app_main(694) > app_efl_main
05-28 08:18:29.621+0900 D/LAUNCH  (23780): appcore-efl.c: appcore_efl_main(1548) > [helloworld:Application:main:done]
05-28 08:18:29.621+0900 D/APP_CORE(23759): appcore-efl.c: __show_cb(814) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2a00009
05-28 08:18:29.621+0900 D/APP_CORE(23759): appcore-efl.c: __add_win(660) > [EVENT_TEST][EVENT] __add_win WIN:2a00009
05-28 08:18:29.621+0900 D/APP_CORE(23759): appcore-efl.c: __update_win(706) > [EVENT_TEST][EVENT] __update_win WIN:2a00009 fully_obscured 0
05-28 08:18:29.621+0900 D/APP_CORE(23759): appcore-efl.c: __visibility_cb(869) > bvisibility 1, b_active -1
05-28 08:18:29.621+0900 D/APP_CORE(23759): appcore-efl.c: __visibility_cb(872) >  Go to Resume state
05-28 08:18:29.621+0900 D/APP_CORE(23759): appcore-efl.c: __do_app(464) > [APP 23759] Event: RESUME State: RUNNING
05-28 08:18:29.621+0900 D/LAUNCH  (23759): appcore-efl.c: __do_app(548) > [crash-popup:Application:resume:start]
05-28 08:18:29.621+0900 D/LAUNCH  (23759): appcore-efl.c: __do_app(558) > [crash-popup:Application:resume:done]
05-28 08:18:29.621+0900 D/LAUNCH  (23759): appcore-efl.c: __do_app(560) > [crash-popup:Application:Launching:done]
05-28 08:18:29.621+0900 D/APP_CORE(23759): appcore-efl.c: __trm_app_info_send_socket(224) > __trm_app_info_send_socket
05-28 08:18:29.621+0900 E/APP_CORE(23759): appcore-efl.c: __trm_app_info_send_socket(227) > access
05-28 08:18:29.621+0900 D/RESOURCED( 2244): proc-monitor.c: proc_dbus_proc_signal_handler(181) > [proc_dbus_proc_signal_handler,181] call proc_dbus_proc_signal_handler : pid = 23759, type = 0
05-28 08:18:29.621+0900 D/RESOURCED( 2244): proc-main.c: resourced_proc_status_change(548) > [SECURE_LOG] [resourced_proc_status_change,548] set foreground : 23759
05-28 08:18:29.621+0900 D/RESOURCED( 2244): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1625) > [lowmem_move_memcgroup,1625] buf : /sys/fs/cgroup/memory/foreground1/cgroup.procs, pid : 23759, score : 200
05-28 08:18:29.651+0900 D/RESOURCED( 2244): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 23759, appname = (null)
05-28 08:18:29.651+0900 D/RESOURCED( 2244): cgroup.c: cgroup_write_node(89) > [SECURE_LOG] [cgroup_write_node,89] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 23759
05-28 08:18:29.651+0900 D/RESOURCED( 2244): cgroup.c: cgroup_write_node(89) > [SECURE_LOG] [cgroup_write_node,89] cgroup_buf /sys/fs/cgroup/timer_slack/exclude/cgroup.procs, value 23759
05-28 08:18:29.651+0900 E/RESOURCED( 2244): file-helper.c: fwrite_str(50) > [fwrite_str,50] Fail to file open
05-28 08:18:29.651+0900 E/RESOURCED( 2244): file-helper.c: fwrite_str(50) > [fwrite_str,50] errno -2, errmsg No such file or directory
05-28 08:18:29.651+0900 I/RESOURCED( 2244): vmpressure-lowmem-handler.c: lowmem_cgroup_handler(1218) > [lowmem_cgroup_handler,1218] anon page (0) is under medium threshold (0)
05-28 08:18:29.691+0900 D/E17_EXTRA_MODULES( 1931): policy.c: _policy_active_win_change(2440) > [SECURE_LOG] [WM] ACT WIN 0x0e00002(2198) -> 0x2a00009(23759)
05-28 08:18:29.691+0900 D/AUL_PAD ( 2016): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
05-28 08:18:29.691+0900 D/AUL_PAD ( 2016): sigchild.h: __send_app_launch_signal(112) > send launch signal done
05-28 08:18:29.691+0900 D/AUL_PAD ( 2016): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
05-28 08:18:29.691+0900 D/AUL     ( 2008): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
05-28 08:18:29.691+0900 E/AUL     ( 2008): simple_util.c: __trm_app_info_send_socket(264) > access
05-28 08:18:29.691+0900 D/AUL_AMD ( 2008): amd_main.c: __add_item_running_list(170) > [SECURE_LOG] __add_item_running_list pid: 23780
05-28 08:18:29.691+0900 D/AUL_AMD ( 2008): amd_main.c: __add_item_running_list(183) > [SECURE_LOG] __add_item_running_list appid: org.tizen.helloworld
05-28 08:18:29.691+0900 D/AUL_AMD ( 2008): amd_launch.c: __e17_status_handler(1886) > pid(23759) status(3)
05-28 08:18:29.691+0900 D/RESOURCED( 2244): proc-noti.c: recv_str(87) > [recv_str,87] str is null
05-28 08:18:29.691+0900 D/RESOURCED( 2244): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2008
05-28 08:18:29.691+0900 D/RESOURCED( 2244): proc-main.c: resourced_proc_action(687) > [SECURE_LOG] [resourced_proc_action,687] appid org.tizen.helloworld, pid 23780, type 4 
05-28 08:18:29.691+0900 D/RESOURCED( 2244): proc-main.c: resourced_proc_status_change(569) > [SECURE_LOG] [resourced_proc_status_change,569] launch request org.tizen.helloworld, 23780
05-28 08:18:29.691+0900 D/RESOURCED( 2244): proc-main.c: resourced_proc_status_change(571) > [SECURE_LOG] [resourced_proc_status_change,571] launch request org.tizen.helloworld with pkgname
05-28 08:18:29.691+0900 D/RESOURCED( 2244): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
05-28 08:18:29.691+0900 D/AUL     ( 2198): launch.c: app_request_to_launchpad(295) > launch request result : 23780
05-28 08:18:29.691+0900 D/MENU_SCREEN( 2198): item.c: item_launch(1004) > Launch app's ret : [23780]
05-28 08:18:29.691+0900 D/LAUNCH  ( 2198): item.c: item_launch(1006) > [org.tizen.helloworld:Menuscreen:launch:done]
05-28 08:18:29.701+0900 D/MENU_SCREEN( 2198): item_event.c: _item_up_cb(86) > ITEM: mouse up event callback is invoked for 0xb8678c28
05-28 08:18:29.701+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(491) > __request_handler: 15
05-28 08:18:29.701+0900 D/AUL_AMD ( 2008): amd_status.c: _status_get_appid_bypid(457) > [SECURE_LOG] appid for 23780 is org.tizen.helloworld
05-28 08:18:29.701+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(659) > APP_GET_APPID_BYPID : 23780 : 0
05-28 08:18:29.701+0900 D/AUL     ( 2175): app_sock.c: __app_send_cmd_with_result(608) > recv result  = 29
05-28 08:18:29.701+0900 D/AUL     ( 2175): app_sock.c: __app_send_raw(264) > pid(-2) : cmd(14)
05-28 08:18:29.701+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(491) > __request_handler: 14
05-28 08:18:29.701+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(652) > [SECURE_LOG] APP_IS_RUNNING : org.tizen.helloworld : 23780
05-28 08:18:29.701+0900 D/AUL_AMD ( 2008): amd_request.c: __send_result_to_client(69) > __send_result_to_client, res: 27
05-28 08:18:29.711+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(491) > __request_handler: 12
05-28 08:18:29.711+0900 D/AUL     ( 2175): app_sock.c: __app_send_cmd_with_result(608) > recv result  = 455
05-28 08:18:29.711+0900 D/indicator( 2175): mp3_playing.c: music_app_terminate_cb(252) > music_app_terminate_cb[252]	 "music_app_terminate_cb"
05-28 08:18:29.711+0900 D/E17_EXTRA_MODULES( 1931): policy.c: _policy_calculate_visibility(6074) > [SECURE_LOG] [WM] SEND VISIBILITY. win:0x2a00009 (old:2 -> new:0)
05-28 08:18:29.731+0900 D/APP_CORE(23780): appcore-efl.c: __before_loop(996) > elm_config_preferred_engine_set is not called
05-28 08:18:29.731+0900 D/AUL     (23780): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 23780 is org.tizen.helloworld
05-28 08:18:29.731+0900 D/APP_CORE(23780): appcore.c: appcore_init(502) > [SECURE_LOG] dir : /usr/apps/org.tizen.helloworld/res/locale
05-28 08:18:29.731+0900 D/APP_CORE(23780): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_US.UTF-8
05-28 08:18:29.731+0900 D/AUL     (23780): app_sock.c: __create_server_sock(135) > pg path - already exists
05-28 08:18:29.731+0900 D/LAUNCH  (23780): appcore-efl.c: __before_loop(1014) > [helloworld:Platform:appcore_init:done]
05-28 08:18:29.731+0900 I/CAPI_APPFW_APPLICATION(23780): app_main.c: _ui_app_appcore_create(555) > app_appcore_create
05-28 08:18:29.751+0900 D/APP_CORE(23759): appcore.c: __prt_ltime(179) > [APP 23759] first idle after reset: 1695 msec
05-28 08:18:29.751+0900 D/APP_CORE(23759): appcore-efl.c: __update_win(706) > [EVENT_TEST][EVENT] __update_win WIN:2a00009 fully_obscured 0
05-28 08:18:29.751+0900 D/APP_CORE(23759): appcore-efl.c: __visibility_cb(869) > bvisibility 1, b_active 1
05-28 08:18:29.751+0900 D/APP_CORE(23759): appcore-efl.c: __visibility_cb(888) >  No change state 
05-28 08:18:29.761+0900 D/APP_CORE(23780): appcore-rotation.c: __dbus_signal_handler_init_with_param(257) > app signal initialized
05-28 08:18:30.071+0900 E/EFL     (23780): evas-gl_x11<23780> evas_x_main.c:255 eng_window_new() eglCreateContext() fail. code=0x3009
05-28 08:18:30.071+0900 E/EFL     (23780): evas-gl_x11<23780> evas_x_main.c:614 eng_window_use() eglMakeCurrent() failed!
05-28 08:18:30.131+0900 E/EFL     (23780): ecore_evas<23780> ecore_evas_x.c:432 _ecore_evas_x_gl_window_new() evas_engine_info_set() for engine 'opengl_x11' failed.
05-28 08:18:30.131+0900 E/EFL     (23780): ecore_evas<23780> ecore_evas_x.c:4635 ecore_evas_gl_x11_options_new() evas_engine_info_set() init engine 'opengl_x11' failed.
05-28 08:18:30.131+0900 F/EFL     (23780): elementary<23780> elm_win.c:3433 elm_win_add() OpenGL engine creation failed. Trying default.
05-28 08:18:30.261+0900 E/EFL     (23780): evas_main<23780> evas_object_main.c:1292 evas_object_color_set() Evas only handles pre multiplied colors!
05-28 08:18:30.281+0900 E/EFL     (23780): evas_main<23780> evas_object_main.c:1297 evas_object_color_set() Evas only handles pre multiplied colors!
05-28 08:18:30.281+0900 E/EFL     (23780): evas_main<23780> evas_object_main.c:1287 evas_object_color_set() Evas only handles pre multiplied colors!
05-28 08:18:30.281+0900 E/EFL     (23780): evas_main<23780> evas_object_main.c:1287 evas_object_color_set() Evas only handles pre multiplied colors!
05-28 08:18:30.341+0900 F/EFL     (23780): evas_main<23780> main.c:122 evas_debug_magic_wrong() Input object is wrong type
05-28 08:18:30.341+0900 F/EFL     (23780):     Expected: 70777770 - Evas
05-28 08:18:30.341+0900 F/EFL     (23780):     Supplied: 71737723 - Evas_Object
05-28 08:18:30.371+0900 W/CRASH_MANAGER(23694): worker.c: worker_job(1189) > 112378068656c1432768710
05-28 08:18:30.391+0900 D/LBS_DBUS_SERVER( 2292): lbs_dbus_server.c: on_name_owner_changed(543) > [SECURE_LOG] service_name :1.929, prev_owner :1.929, new_owner 
05-28 08:18:30.411+0900 I/AUL_PAD ( 2016): sigchild.h: __launchpad_sig_child(142) > dead_pid = 23780 pgid = 23780
05-28 08:18:30.411+0900 I/AUL_PAD ( 2016): sigchild.h: __sigchild_action(123) > dead_pid(23780)
05-28 08:18:30.411+0900 D/AUL_PAD ( 2016): sigchild.h: __send_app_dead_signal(81) > send dead signal done
05-28 08:18:30.411+0900 I/AUL_PAD ( 2016): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
05-28 08:18:30.411+0900 I/AUL_PAD ( 2016): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
05-28 08:18:30.411+0900 I/AUL_AMD ( 2008): amd_main.c: __app_dead_handler(257) > __app_dead_handler, pid: 23780
05-28 08:18:30.411+0900 D/AUL_AMD ( 2008): amd_key.c: _unregister_key_event(156) > ===key stack===
05-28 08:18:30.411+0900 D/AUL     ( 2008): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
05-28 08:18:30.411+0900 E/AUL     ( 2008): simple_util.c: __trm_app_info_send_socket(264) > access
05-28 08:18:30.411+0900 D/STARTER ( 2182): lock-daemon-lite.c: lockd_app_dead_cb_lite(991) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/lock-daemon-lite.c:991:D] app dead cb call! (pid : 23780)
05-28 08:18:30.411+0900 D/STARTER ( 2182): menu_daemon.c: menu_daemon_check_dead_signal(626) > [menu_daemon_check_dead_signal:626] Process 23780 is termianted
05-28 08:18:30.411+0900 D/STARTER ( 2182): menu_daemon.c: menu_daemon_check_dead_signal(647) > [menu_daemon_check_dead_signal:647] Unknown process, ignore it (dead pid 23780, home pid 2198, taskmgr pid 2204)
05-28 08:18:30.411+0900 D/indicator( 2175): mp3_playing.c: music_app_terminate_cb(252) > music_app_terminate_cb[252]	 "music_app_terminate_cb"
05-28 08:18:30.411+0900 D/indicator( 2175): mp3_playing.c: music_app_terminate_cb(255) > music_app_terminate_cb[255]	 "hide music icon"
05-28 08:18:30.711+0900 D/AUL_AMD ( 2008): amd_request.c: __add_history_handler(243) > [SECURE_LOG] add rua history org.tizen.helloworld /opt/usr/apps/org.tizen.helloworld/bin/helloworld
05-28 08:18:30.711+0900 D/RUA     ( 2008): rua.c: rua_add_history(179) > rua_add_history start
05-28 08:18:30.711+0900 D/RUA     ( 2008): rua.c: rua_add_history(208) > query : REPLACE INTO rua_history(pkg_name,app_path,arg,launch_time) VALUES (?,?,?,?)
05-28 08:18:30.711+0900 D/MENU_SCREEN( 2198): layout.c: layout_disable_block(127) > Disable layout blocker
05-28 08:18:30.921+0900 D/EFL     (23759): ecore_x<23759> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=42559938 button=1
05-28 08:18:31.021+0900 D/EFL     (23759): ecore_x<23759> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=42560028 button=1
05-28 08:18:31.131+0900 D/RUA     ( 2008): rua.c: rua_add_history(249) > rua_add_history ok
05-28 08:18:31.241+0900 D/EFL     (23759): ecore_x<23759> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=42560250 button=1
05-28 08:18:31.311+0900 D/EFL     (23759): ecore_x<23759> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=42560317 button=1
05-28 08:18:31.331+0900 D/AUL     (23759): app_sock.c: __app_send_raw_with_noreply(363) > pid(-2) : cmd(22)
05-28 08:18:31.331+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(491) > __request_handler: 22
05-28 08:18:31.331+0900 D/APP_CORE(23759): appcore-efl.c: __after_loop(1039) > [APP 23759] PAUSE before termination
05-28 08:18:31.411+0900 D/E17_EXTRA_MODULES( 1931): policy.c: _policy_active_win_change(2440) > [SECURE_LOG] [WM] ACT WIN 0x2a00009(23759) -> 0x0e00002(2198)
05-28 08:18:31.471+0900 I/AUL_PAD ( 2016): sigchild.h: __launchpad_sig_child(142) > dead_pid = 23759 pgid = 23759
05-28 08:18:31.471+0900 I/AUL_PAD ( 2016): sigchild.h: __sigchild_action(123) > dead_pid(23759)
05-28 08:18:31.471+0900 D/AUL_PAD ( 2016): sigchild.h: __send_app_dead_signal(81) > send dead signal done
05-28 08:18:31.471+0900 I/AUL_PAD ( 2016): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
05-28 08:18:31.471+0900 I/AUL_PAD ( 2016): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
05-28 08:18:31.471+0900 D/LBS_DBUS_SERVER( 2292): lbs_dbus_server.c: on_name_owner_changed(543) > [SECURE_LOG] service_name :1.927, prev_owner :1.927, new_owner 
05-28 08:18:31.471+0900 D/LBS_DBUS_SERVER( 2292): lbs_dbus_server.c: on_name_owner_changed(543) > [SECURE_LOG] service_name :1.928, prev_owner :1.928, new_owner 
05-28 08:18:31.471+0900 D/STARTER ( 2182): lock-daemon-lite.c: lockd_app_dead_cb_lite(991) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/lock-daemon-lite.c:991:D] app dead cb call! (pid : 23759)
05-28 08:18:31.471+0900 D/STARTER ( 2182): menu_daemon.c: menu_daemon_check_dead_signal(626) > [menu_daemon_check_dead_signal:626] Process 23759 is termianted
05-28 08:18:31.471+0900 D/STARTER ( 2182): menu_daemon.c: menu_daemon_check_dead_signal(647) > [menu_daemon_check_dead_signal:647] Unknown process, ignore it (dead pid 23759, home pid 2198, taskmgr pid 2204)
05-28 08:18:31.471+0900 I/AUL_AMD ( 2008): amd_main.c: __app_dead_handler(257) > __app_dead_handler, pid: 23759
05-28 08:18:31.471+0900 D/AUL_AMD ( 2008): amd_key.c: _unregister_key_event(156) > ===key stack===
05-28 08:18:31.471+0900 D/AUL     ( 2008): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
05-28 08:18:31.471+0900 E/AUL     ( 2008): simple_util.c: __trm_app_info_send_socket(264) > access
05-28 08:18:31.481+0900 D/indicator( 2175): mp3_playing.c: music_app_terminate_cb(252) > music_app_terminate_cb[252]	 "music_app_terminate_cb"
05-28 08:18:31.481+0900 D/indicator( 2175): mp3_playing.c: music_app_terminate_cb(255) > music_app_terminate_cb[255]	 "hide music icon"
05-28 08:18:32.981+0900 D/PKGMGR_INFO(23694): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(2994) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.tizen.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
05-28 08:18:32.981+0900 D/PKGMGR_INFO(23694): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3000) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-us' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.tizen.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
05-28 08:18:32.981+0900 D/PKGMGR_INFO(23694): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3108) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.tizen.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
05-28 08:18:32.981+0900 D/PKGMGR_INFO(23694): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3114) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.tizen.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
05-28 08:18:32.981+0900 D/PKGMGR_INFO(23694): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3108) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.tizen.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
05-28 08:18:32.981+0900 D/PKGMGR_INFO(23694): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3114) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.tizen.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
05-28 08:18:33.051+0900 D/LBS_DBUS_SERVER( 2292): lbs_dbus_server.c: on_name_owner_changed(543) > [SECURE_LOG] service_name org.tizen.system.popup, prev_owner :1.926, new_owner 
05-28 08:18:33.051+0900 D/LBS_DBUS_SERVER( 2292): lbs_dbus_server.c: on_name_owner_changed(543) > [SECURE_LOG] service_name :1.926, prev_owner :1.926, new_owner 
05-28 08:18:33.221+0900 D/AUL     (23802): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : com.samsung.crash-popup
05-28 08:18:33.221+0900 D/AUL     (23802): app_sock.c: __app_send_raw(264) > pid(-2) : cmd(0)
05-28 08:18:33.221+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(491) > __request_handler: 0
05-28 08:18:33.221+0900 D/AUL     ( 2008): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 1976, pid = 23802
05-28 08:18:33.221+0900 D/AUL_AMD ( 2008): amd_launch.c: _start_app(1464) > [SECURE_LOG] caller : (null)
05-28 08:18:33.221+0900 D/AUL_AMD ( 2008): amd_launch.c: _start_app(1768) > process_pool: false
05-28 08:18:33.221+0900 D/AUL_AMD ( 2008): amd_launch.c: _start_app(1771) > h/w acceleration: SYS
05-28 08:18:33.221+0900 D/AUL_AMD ( 2008): amd_launch.c: _start_app(1773) > [SECURE_LOG] appid: com.samsung.crash-popup
05-28 08:18:33.221+0900 D/AUL_AMD ( 2008): amd_launch.c: __set_appinfo_for_launchpad(1925) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-28 08:18:33.221+0900 D/AUL     ( 2008): app_sock.c: __app_send_raw(264) > pid(-1) : cmd(0)
05-28 08:18:33.221+0900 D/AUL_PAD ( 2016): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : com.samsung.crash-popup
05-28 08:18:33.221+0900 D/AUL_PAD ( 2016): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
05-28 08:18:33.221+0900 D/AUL_PAD ( 2016): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 23803 /usr/apps/com.samsung.crash-popup/bin/crash-popup
05-28 08:18:33.221+0900 D/AUL_PAD ( 2016): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
05-28 08:18:33.221+0900 D/AUL_PAD (23803): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
05-28 08:18:33.221+0900 D/AUL_PAD (23803): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
05-28 08:18:33.221+0900 D/AUL_PAD (23803): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : com.samsung.crash-popup / pkg_type : rpm / app_path : /usr/apps/com.samsung.crash-popup/bin/crash-popup 
05-28 08:18:33.221+0900 D/AUL_PAD (23803): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
05-28 08:18:33.221+0900 D/AUL_PAD (23803): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /usr/apps/com.samsung.crash-popup/bin/crash-popup##
05-28 08:18:33.221+0900 D/AUL_PAD (23803): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : _PROCESS_NAME_##
05-28 08:18:33.221+0900 D/AUL_PAD (23803): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : _EXEPATH_##
05-28 08:18:33.221+0900 D/AUL_PAD (23803): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : _INTERNAL_SYSPOPUP_NAME_##
05-28 08:18:33.221+0900 D/AUL_PAD (23803): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_STARTTIME__##
05-28 08:18:33.221+0900 D/AUL_PAD (23803): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_PID__##
05-28 08:18:33.221+0900 D/LAUNCH  (23803): launchpad.c: __real_launch(229) > [SECURE_LOG] [/usr/apps/com.samsung.crash-popup/bin/crash-popup:Platform:launchpad:done]
05-28 08:18:33.261+0900 D/LAUNCH  (23803): appcore-efl.c: appcore_efl_main(1548) > [crash-popup:Application:main:done]
05-28 08:18:33.261+0900 D/APP_CORE(23803): appcore-efl.c: __before_loop(996) > elm_config_preferred_engine_set is not called
05-28 08:18:33.261+0900 D/AUL     (23803): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 23803 is com.samsung.crash-popup
05-28 08:18:33.261+0900 D/APP_CORE(23803): appcore.c: appcore_init(502) > [SECURE_LOG] dir : /usr/apps/com.samsung.crash-popup/res/locale
05-28 08:18:33.261+0900 D/APP_CORE(23803): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_US.UTF-8
05-28 08:18:33.261+0900 D/AUL     (23803): app_sock.c: __create_server_sock(135) > pg path - already exists
05-28 08:18:33.261+0900 D/LAUNCH  (23803): appcore-efl.c: __before_loop(1014) > [crash-popup:Platform:appcore_init:done]
05-28 08:18:33.321+0900 D/AUL_PAD ( 2016): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
05-28 08:18:33.321+0900 D/AUL_PAD ( 2016): sigchild.h: __send_app_launch_signal(112) > send launch signal done
05-28 08:18:33.321+0900 D/AUL_PAD ( 2016): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
05-28 08:18:33.321+0900 D/AUL     ( 2008): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
05-28 08:18:33.321+0900 E/AUL     ( 2008): simple_util.c: __trm_app_info_send_socket(264) > access
05-28 08:18:33.321+0900 D/AUL_AMD ( 2008): amd_main.c: __add_item_running_list(170) > [SECURE_LOG] __add_item_running_list pid: 23803
05-28 08:18:33.321+0900 D/AUL_AMD ( 2008): amd_main.c: __add_item_running_list(183) > [SECURE_LOG] __add_item_running_list appid: com.samsung.crash-popup
05-28 08:18:33.341+0900 D/RESOURCED( 2244): proc-noti.c: recv_str(87) > [recv_str,87] str is null
05-28 08:18:33.341+0900 D/RESOURCED( 2244): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2008
05-28 08:18:33.341+0900 D/RESOURCED( 2244): proc-main.c: resourced_proc_action(687) > [SECURE_LOG] [resourced_proc_action,687] appid com.samsung.crash-popup, pid 23803, type 4 
05-28 08:18:33.341+0900 D/RESOURCED( 2244): proc-main.c: resourced_proc_status_change(569) > [SECURE_LOG] [resourced_proc_status_change,569] launch request com.samsung.crash-popup, 23803
05-28 08:18:33.341+0900 D/RESOURCED( 2244): proc-main.c: resourced_proc_status_change(571) > [SECURE_LOG] [resourced_proc_status_change,571] launch request com.samsung.crash-popup with pkgname
05-28 08:18:33.341+0900 D/RESOURCED( 2244): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
05-28 08:18:33.341+0900 D/AUL     (23802): launch.c: app_request_to_launchpad(295) > launch request result : 23803
05-28 08:18:33.411+0900 D/AUL_AMD ( 2008): amd_status.c: __app_terminate_timer_cb(157) > pid(23759)
05-28 08:18:33.411+0900 D/AUL_AMD ( 2008): amd_status.c: __app_terminate_timer_cb(161) > send SIGKILL: No such process
05-28 08:18:34.021+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(491) > __request_handler: 15
05-28 08:18:34.021+0900 D/AUL_AMD ( 2008): amd_status.c: _status_get_appid_bypid(457) > [SECURE_LOG] appid for 23803 is com.samsung.crash-popup
05-28 08:18:34.021+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(659) > APP_GET_APPID_BYPID : 23803 : 0
05-28 08:18:34.021+0900 D/AUL     ( 2175): app_sock.c: __app_send_cmd_with_result(608) > recv result  = 32
05-28 08:18:34.021+0900 D/AUL     ( 2175): app_sock.c: __app_send_raw(264) > pid(-2) : cmd(14)
05-28 08:18:34.021+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(491) > __request_handler: 14
05-28 08:18:34.021+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(652) > [SECURE_LOG] APP_IS_RUNNING : com.samsung.crash-popup : 23803
05-28 08:18:34.021+0900 D/AUL_AMD ( 2008): amd_request.c: __send_result_to_client(69) > __send_result_to_client, res: 27
05-28 08:18:34.021+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(491) > __request_handler: 12
05-28 08:18:34.021+0900 D/AUL     ( 2175): app_sock.c: __app_send_cmd_with_result(608) > recv result  = 378
05-28 08:18:34.021+0900 D/indicator( 2175): mp3_playing.c: music_app_terminate_cb(252) > music_app_terminate_cb[252]	 "music_app_terminate_cb"
05-28 08:18:34.331+0900 D/AUL_AMD ( 2008): amd_launch.c: __grab_timeout_handler(1197) > pid(23803) ecore_x_pointer_ungrab
05-28 08:18:34.331+0900 D/AUL_AMD ( 2008): amd_request.c: __add_history_handler(243) > [SECURE_LOG] add rua history com.samsung.crash-popup /usr/apps/com.samsung.crash-popup/bin/crash-popup
05-28 08:18:34.331+0900 D/RUA     ( 2008): rua.c: rua_add_history(179) > rua_add_history start
05-28 08:18:34.331+0900 D/RUA     ( 2008): rua.c: rua_add_history(208) > query : REPLACE INTO rua_history(pkg_name,app_path,arg,launch_time) VALUES (?,?,?,?)
05-28 08:18:34.491+0900 D/APP_CORE(23803): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_US.UTF-8
05-28 08:18:34.491+0900 D/LAUNCH  (23803): appcore-efl.c: __before_loop(1024) > [crash-popup:Application:create:done]
05-28 08:18:34.491+0900 D/APP_CORE(23803): appcore-efl.c: __check_wm_rotation_support(740) > Disable window manager rotation
05-28 08:18:34.491+0900 D/APP_CORE(23803): appcore.c: __aul_handler(403) > [APP 23803]     AUL event: AUL_START
05-28 08:18:34.491+0900 D/APP_CORE(23803): appcore-efl.c: __do_app(464) > [APP 23803] Event: RESET State: CREATED
05-28 08:18:34.491+0900 D/APP_CORE(23803): appcore-efl.c: __do_app(490) > [APP 23803] RESET
05-28 08:18:34.491+0900 D/LAUNCH  (23803): appcore-efl.c: __do_app(492) > [crash-popup:Application:reset:start]
05-28 08:18:34.511+0900 D/CRASH_POPUP(23803): crash.c: app_reset(216) > bundle_get_val - process_name:helloworld
05-28 08:18:34.511+0900 D/CRASH_POPUP(23803): crash.c: app_reset(223) > bundle_get_val - exepath:/opt/usr/apps/org.tizen.helloworld/bin/helloworld
05-28 08:18:34.511+0900 D/PKGMGR_INFO(23803): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(2994) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.tizen.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
05-28 08:18:34.511+0900 D/PKGMGR_INFO(23803): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3000) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-us' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.tizen.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
05-28 08:18:34.511+0900 D/PKGMGR_INFO(23803): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3108) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.tizen.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
05-28 08:18:34.511+0900 D/PKGMGR_INFO(23803): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3114) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-us') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.tizen.helloworld/bin/helloworld' and package_app_info.app_disable IN ('false','False')
05-28 08:18:34.511+0900 I/CRASH_POPUP(23803): crash.c: load_crash_process_popup(117) > Popup content: helloworld has closed unexpectedly.
05-28 08:18:34.581+0900 D/LAUNCH  (23803): appcore-efl.c: __do_app(495) > [crash-popup:Application:reset:done]
05-28 08:18:34.581+0900 I/APP_CORE(23803): appcore-efl.c: __do_app(501) > Legacy lifecycle: 0
05-28 08:18:34.591+0900 I/APP_CORE(23803): appcore-efl.c: __do_app(503) > [APP 23803] Initial Launching, call the resume_cb
05-28 08:18:34.591+0900 D/APP_CORE(23803): appcore.c: __aul_handler(406) > [SECURE_LOG] caller_appid : (null)
05-28 08:18:34.601+0900 D/APP_CORE(23803): appcore-efl.c: __show_cb(814) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2a00009
05-28 08:18:34.601+0900 D/APP_CORE(23803): appcore-efl.c: __add_win(660) > [EVENT_TEST][EVENT] __add_win WIN:2a00009
05-28 08:18:34.601+0900 D/RESOURCED( 2244): proc-monitor.c: proc_dbus_proc_signal_handler(181) > [proc_dbus_proc_signal_handler,181] call proc_dbus_proc_signal_handler : pid = 23803, type = 0
05-28 08:18:34.601+0900 D/RESOURCED( 2244): proc-main.c: resourced_proc_status_change(548) > [SECURE_LOG] [resourced_proc_status_change,548] set foreground : 23803
05-28 08:18:34.601+0900 D/RESOURCED( 2244): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1625) > [lowmem_move_memcgroup,1625] buf : /sys/fs/cgroup/memory/foreground1/cgroup.procs, pid : 23803, score : 200
05-28 08:18:34.631+0900 D/RESOURCED( 2244): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 23803, appname = (null)
05-28 08:18:34.631+0900 D/RESOURCED( 2244): cgroup.c: cgroup_write_node(89) > [SECURE_LOG] [cgroup_write_node,89] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 23803
05-28 08:18:34.631+0900 D/RESOURCED( 2244): cgroup.c: cgroup_write_node(89) > [SECURE_LOG] [cgroup_write_node,89] cgroup_buf /sys/fs/cgroup/timer_slack/exclude/cgroup.procs, value 23803
05-28 08:18:34.631+0900 E/RESOURCED( 2244): file-helper.c: fwrite_str(50) > [fwrite_str,50] Fail to file open
05-28 08:18:34.631+0900 E/RESOURCED( 2244): file-helper.c: fwrite_str(50) > [fwrite_str,50] errno -2, errmsg No such file or directory
05-28 08:18:34.631+0900 I/RESOURCED( 2244): vmpressure-lowmem-handler.c: lowmem_cgroup_handler(1218) > [lowmem_cgroup_handler,1218] anon page (0) is under medium threshold (0)
05-28 08:18:34.661+0900 D/APP_CORE(23803): appcore-efl.c: __update_win(706) > [EVENT_TEST][EVENT] __update_win WIN:2a00009 fully_obscured 0
05-28 08:18:34.661+0900 D/APP_CORE(23803): appcore-efl.c: __visibility_cb(869) > bvisibility 1, b_active -1
05-28 08:18:34.661+0900 D/APP_CORE(23803): appcore-efl.c: __visibility_cb(872) >  Go to Resume state
05-28 08:18:34.661+0900 D/APP_CORE(23803): appcore-efl.c: __do_app(464) > [APP 23803] Event: RESUME State: RUNNING
05-28 08:18:34.661+0900 D/LAUNCH  (23803): appcore-efl.c: __do_app(548) > [crash-popup:Application:resume:start]
05-28 08:18:34.661+0900 D/LAUNCH  (23803): appcore-efl.c: __do_app(558) > [crash-popup:Application:resume:done]
05-28 08:18:34.661+0900 D/LAUNCH  (23803): appcore-efl.c: __do_app(560) > [crash-popup:Application:Launching:done]
05-28 08:18:34.661+0900 D/APP_CORE(23803): appcore-efl.c: __trm_app_info_send_socket(224) > __trm_app_info_send_socket
05-28 08:18:34.661+0900 E/APP_CORE(23803): appcore-efl.c: __trm_app_info_send_socket(227) > access
05-28 08:18:34.661+0900 D/E17_EXTRA_MODULES( 1931): policy.c: _policy_active_win_change(2440) > [SECURE_LOG] [WM] ACT WIN 0x0e00002(2198) -> 0x2a00009(23803)
05-28 08:18:34.671+0900 D/E17_EXTRA_MODULES( 1931): policy.c: _policy_calculate_visibility(6074) > [SECURE_LOG] [WM] SEND VISIBILITY. win:0x2a00009 (old:2 -> new:0)
05-28 08:18:34.671+0900 D/RUA     ( 2008): rua.c: rua_add_history(249) > rua_add_history ok
05-28 08:18:34.671+0900 D/AUL_AMD ( 2008): amd_launch.c: __e17_status_handler(1886) > pid(23803) status(3)
05-28 08:18:34.721+0900 D/APP_CORE(23803): appcore-efl.c: __update_win(706) > [EVENT_TEST][EVENT] __update_win WIN:2a00009 fully_obscured 0
05-28 08:18:34.721+0900 D/APP_CORE(23803): appcore-efl.c: __visibility_cb(869) > bvisibility 1, b_active 1
05-28 08:18:34.721+0900 D/APP_CORE(23803): appcore-efl.c: __visibility_cb(888) >  No change state 
05-28 08:18:34.771+0900 D/APP_CORE(23803): appcore.c: __prt_ltime(179) > [APP 23803] first idle after reset: 1552 msec
05-28 08:18:36.391+0900 D/EFL     (23803): ecore_x<23803> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=42565398 button=1
05-28 08:18:36.471+0900 D/EFL     (23803): ecore_x<23803> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=42565472 button=1
05-28 08:18:36.491+0900 D/AUL     (23803): app_sock.c: __app_send_raw_with_noreply(363) > pid(-2) : cmd(22)
05-28 08:18:36.491+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(491) > __request_handler: 22
05-28 08:18:36.491+0900 D/APP_CORE(23803): appcore-efl.c: __after_loop(1039) > [APP 23803] PAUSE before termination
05-28 08:18:36.561+0900 D/E17_EXTRA_MODULES( 1931): policy.c: _policy_active_win_change(2440) > [SECURE_LOG] [WM] ACT WIN 0x2a00009(23803) -> 0x0e00002(2198)
05-28 08:18:36.611+0900 D/LBS_DBUS_SERVER( 2292): lbs_dbus_server.c: on_name_owner_changed(543) > [SECURE_LOG] service_name :1.931, prev_owner :1.931, new_owner 
05-28 08:18:36.621+0900 D/LBS_DBUS_SERVER( 2292): lbs_dbus_server.c: on_name_owner_changed(543) > [SECURE_LOG] service_name :1.932, prev_owner :1.932, new_owner 
05-28 08:18:36.621+0900 I/AUL_PAD ( 2016): sigchild.h: __launchpad_sig_child(142) > dead_pid = 23803 pgid = 23803
05-28 08:18:36.621+0900 I/AUL_PAD ( 2016): sigchild.h: __sigchild_action(123) > dead_pid(23803)
05-28 08:18:36.621+0900 D/AUL_PAD ( 2016): sigchild.h: __send_app_dead_signal(81) > send dead signal done
05-28 08:18:36.621+0900 I/AUL_PAD ( 2016): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
05-28 08:18:36.621+0900 I/AUL_PAD ( 2016): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
05-28 08:18:36.621+0900 D/STARTER ( 2182): lock-daemon-lite.c: lockd_app_dead_cb_lite(991) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/lock-daemon-lite.c:991:D] app dead cb call! (pid : 23803)
05-28 08:18:36.621+0900 D/STARTER ( 2182): menu_daemon.c: menu_daemon_check_dead_signal(626) > [menu_daemon_check_dead_signal:626] Process 23803 is termianted
05-28 08:18:36.621+0900 D/STARTER ( 2182): menu_daemon.c: menu_daemon_check_dead_signal(647) > [menu_daemon_check_dead_signal:647] Unknown process, ignore it (dead pid 23803, home pid 2198, taskmgr pid 2204)
05-28 08:18:36.621+0900 I/AUL_AMD ( 2008): amd_main.c: __app_dead_handler(257) > __app_dead_handler, pid: 23803
05-28 08:18:36.621+0900 D/AUL_AMD ( 2008): amd_key.c: _unregister_key_event(156) > ===key stack===
05-28 08:18:36.621+0900 D/AUL     ( 2008): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
05-28 08:18:36.621+0900 E/AUL     ( 2008): simple_util.c: __trm_app_info_send_socket(264) > access
05-28 08:18:36.621+0900 D/indicator( 2175): mp3_playing.c: music_app_terminate_cb(252) > music_app_terminate_cb[252]	 "music_app_terminate_cb"
05-28 08:18:36.621+0900 D/indicator( 2175): mp3_playing.c: music_app_terminate_cb(255) > music_app_terminate_cb[255]	 "hide music icon"
05-28 08:18:36.981+0900 D/EFL     ( 2198): ecore_x<2198> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=42565986 button=1
05-28 08:18:36.981+0900 D/MENU_SCREEN( 2198): mouse.c: _down_cb(104) > Mouse down (322,522)
05-28 08:18:37.051+0900 D/EFL     ( 2198): ecore_x<2198> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=42566066 button=1
05-28 08:18:37.051+0900 D/MENU_SCREEN( 2198): mouse.c: _up_cb(121) > Mouse up (322,522)
05-28 08:18:38.221+0900 D/LBS_DBUS_SERVER( 2292): lbs_dbus_server.c: on_name_owner_changed(543) > [SECURE_LOG] service_name org.tizen.system.popup, prev_owner :1.930, new_owner 
05-28 08:18:38.221+0900 D/LBS_DBUS_SERVER( 2292): lbs_dbus_server.c: on_name_owner_changed(543) > [SECURE_LOG] service_name :1.930, prev_owner :1.930, new_owner 
05-28 08:18:38.391+0900 D/EFL     ( 2198): ecore_x<2198> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=42567399 button=1
05-28 08:18:38.391+0900 D/MENU_SCREEN( 2198): mouse.c: _down_cb(104) > Mouse down (388,498)
05-28 08:18:38.461+0900 D/EFL     ( 2198): ecore_x<2198> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=42567466 button=1
05-28 08:18:38.461+0900 D/MENU_SCREEN( 2198): mouse.c: _up_cb(121) > Mouse up (388,498)
05-28 08:18:38.491+0900 D/AUL_AMD ( 2008): amd_status.c: __app_terminate_timer_cb(157) > pid(23803)
05-28 08:18:38.491+0900 D/AUL_AMD ( 2008): amd_status.c: __app_terminate_timer_cb(161) > send SIGKILL: No such process
05-28 08:18:53.430+0900 D/EFL     ( 2198): ecore_x<2198> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=42582435 button=1
05-28 08:18:53.430+0900 D/MENU_SCREEN( 2198): mouse.c: _down_cb(104) > Mouse down (176,176)
05-28 08:18:53.430+0900 D/MENU_SCREEN( 2198): item_event.c: _item_down_cb(64) > ITEM: mouse down event callback is invoked for 0xb8678c28
05-28 08:18:53.520+0900 D/EFL     ( 2198): ecore_x<2198> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=42582528 button=1
05-28 08:18:53.520+0900 D/MENU_SCREEN( 2198): mouse.c: _up_cb(121) > Mouse up (176,176)
05-28 08:18:53.520+0900 D/MENU_SCREEN( 2198): item.c: _focus_clicked_cb(669) > ITEM: mouse up event callback is invoked for 0xb8678c28
05-28 08:18:53.520+0900 D/MENU_SCREEN( 2198): layout.c: layout_enable_block(117) > Enable layout blocker
05-28 08:18:53.520+0900 D/AUL     ( 2198): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.tizen.helloworld
05-28 08:18:53.520+0900 D/AUL     ( 2198): app_sock.c: __app_send_raw(264) > pid(-2) : cmd(1)
05-28 08:18:53.520+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(491) > __request_handler: 1
05-28 08:18:53.520+0900 D/AUL_AMD ( 2008): amd_launch.c: _start_app(1464) > [SECURE_LOG] caller : com.samsung.menu-screen
05-28 08:18:53.530+0900 D/AUL_AMD ( 2008): amd_launch.c: _start_app(1673) > org.tizen.system.coord.rotation-Degree : 0
05-28 08:18:53.530+0900 D/AUL_AMD ( 2008): amd_launch.c: _start_app(1768) > process_pool: false
05-28 08:18:53.530+0900 D/AUL_AMD ( 2008): amd_launch.c: _start_app(1771) > h/w acceleration: SYS
05-28 08:18:53.530+0900 D/AUL_AMD ( 2008): amd_launch.c: _start_app(1773) > [SECURE_LOG] appid: org.tizen.helloworld
05-28 08:18:53.530+0900 D/AUL_AMD ( 2008): amd_launch.c: __set_appinfo_for_launchpad(1925) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-28 08:18:53.530+0900 D/AUL     ( 2008): app_sock.c: __app_send_raw(264) > pid(-1) : cmd(1)
05-28 08:18:53.530+0900 D/AUL_PAD ( 2016): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.tizen.helloworld
05-28 08:18:53.530+0900 D/AUL_PAD ( 2016): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
05-28 08:18:53.530+0900 D/AUL_PAD ( 2016): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 23827 /opt/usr/apps/org.tizen.helloworld/bin/helloworld
05-28 08:18:53.530+0900 D/AUL_PAD ( 2016): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
05-28 08:18:53.530+0900 D/AUL_PAD (23827): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
05-28 08:18:53.530+0900 D/AUL_PAD (23827): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
05-28 08:18:53.530+0900 D/AUL_PAD (23827): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.tizen.helloworld / pkg_type : rpm / app_path : /opt/usr/apps/org.tizen.helloworld/bin/helloworld 
05-28 08:18:53.530+0900 D/AUL_PAD (23827): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
05-28 08:18:53.540+0900 D/AUL_PAD (23827): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.tizen.helloworld/bin/helloworld##
05-28 08:18:53.540+0900 D/AUL_PAD (23827): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
05-28 08:18:53.540+0900 D/AUL_PAD (23827): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
05-28 08:18:53.540+0900 D/AUL_PAD (23827): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : __AUL_CALLER_APPID__##
05-28 08:18:53.540+0900 D/LAUNCH  (23827): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.tizen.helloworld/bin/helloworld:Platform:launchpad:done]
05-28 08:18:53.540+0900 I/CAPI_APPFW_APPLICATION(23827): app_main.c: ui_app_main(694) > app_efl_main
05-28 08:18:53.540+0900 D/LAUNCH  (23827): appcore-efl.c: appcore_efl_main(1548) > [helloworld:Application:main:done]
05-28 08:18:53.560+0900 D/APP_CORE(23827): appcore-efl.c: __before_loop(996) > elm_config_preferred_engine_set is not called
05-28 08:18:53.560+0900 D/AUL     (23827): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 23827 is org.tizen.helloworld
05-28 08:18:53.560+0900 D/APP_CORE(23827): appcore.c: appcore_init(502) > [SECURE_LOG] dir : /usr/apps/org.tizen.helloworld/res/locale
05-28 08:18:53.560+0900 D/APP_CORE(23827): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_US.UTF-8
05-28 08:18:53.560+0900 D/AUL     (23827): app_sock.c: __create_server_sock(135) > pg path - already exists
05-28 08:18:53.560+0900 D/LAUNCH  (23827): appcore-efl.c: __before_loop(1014) > [helloworld:Platform:appcore_init:done]
05-28 08:18:53.560+0900 I/CAPI_APPFW_APPLICATION(23827): app_main.c: _ui_app_appcore_create(555) > app_appcore_create
05-28 08:18:53.570+0900 D/APP_CORE(23827): appcore-rotation.c: __dbus_signal_handler_init_with_param(257) > app signal initialized
05-28 08:18:53.620+0900 D/AUL_PAD ( 2016): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
05-28 08:18:53.620+0900 D/AUL_PAD ( 2016): sigchild.h: __send_app_launch_signal(112) > send launch signal done
05-28 08:18:53.620+0900 D/AUL_PAD ( 2016): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
05-28 08:18:53.620+0900 D/AUL     ( 2008): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
05-28 08:18:53.620+0900 E/AUL     ( 2008): simple_util.c: __trm_app_info_send_socket(264) > access
05-28 08:18:53.620+0900 D/AUL_AMD ( 2008): amd_main.c: __add_item_running_list(170) > [SECURE_LOG] __add_item_running_list pid: 23827
05-28 08:18:53.620+0900 D/AUL_AMD ( 2008): amd_main.c: __add_item_running_list(183) > [SECURE_LOG] __add_item_running_list appid: org.tizen.helloworld
05-28 08:18:53.620+0900 D/RESOURCED( 2244): proc-noti.c: recv_str(87) > [recv_str,87] str is null
05-28 08:18:53.620+0900 D/RESOURCED( 2244): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2008
05-28 08:18:53.620+0900 D/RESOURCED( 2244): proc-main.c: resourced_proc_action(687) > [SECURE_LOG] [resourced_proc_action,687] appid org.tizen.helloworld, pid 23827, type 4 
05-28 08:18:53.620+0900 D/RESOURCED( 2244): proc-main.c: resourced_proc_status_change(569) > [SECURE_LOG] [resourced_proc_status_change,569] launch request org.tizen.helloworld, 23827
05-28 08:18:53.620+0900 D/RESOURCED( 2244): proc-main.c: resourced_proc_status_change(571) > [SECURE_LOG] [resourced_proc_status_change,571] launch request org.tizen.helloworld with pkgname
05-28 08:18:53.620+0900 D/RESOURCED( 2244): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
05-28 08:18:53.620+0900 D/AUL     ( 2198): launch.c: app_request_to_launchpad(295) > launch request result : 23827
05-28 08:18:53.620+0900 D/MENU_SCREEN( 2198): item.c: item_launch(1004) > Launch app's ret : [23827]
05-28 08:18:53.620+0900 D/LAUNCH  ( 2198): item.c: item_launch(1006) > [org.tizen.helloworld:Menuscreen:launch:done]
05-28 08:18:53.620+0900 D/MENU_SCREEN( 2198): item_event.c: _item_up_cb(86) > ITEM: mouse up event callback is invoked for 0xb8678c28
05-28 08:18:53.660+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(491) > __request_handler: 15
05-28 08:18:53.660+0900 D/AUL_AMD ( 2008): amd_status.c: _status_get_appid_bypid(457) > [SECURE_LOG] appid for 23827 is org.tizen.helloworld
05-28 08:18:53.660+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(659) > APP_GET_APPID_BYPID : 23827 : 0
05-28 08:18:53.680+0900 D/AUL     ( 2175): app_sock.c: __app_send_cmd_with_result(608) > recv result  = 29
05-28 08:18:53.680+0900 D/AUL     ( 2175): app_sock.c: __app_send_raw(264) > pid(-2) : cmd(14)
05-28 08:18:53.680+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(491) > __request_handler: 14
05-28 08:18:53.680+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(652) > [SECURE_LOG] APP_IS_RUNNING : org.tizen.helloworld : 23827
05-28 08:18:53.680+0900 D/AUL_AMD ( 2008): amd_request.c: __send_result_to_client(69) > __send_result_to_client, res: 27
05-28 08:18:53.680+0900 D/AUL_AMD ( 2008): amd_request.c: __request_handler(491) > __request_handler: 12
05-28 08:18:53.690+0900 D/AUL     ( 2175): app_sock.c: __app_send_cmd_with_result(608) > recv result  = 375
05-28 08:18:53.690+0900 D/indicator( 2175): mp3_playing.c: music_app_terminate_cb(252) > music_app_terminate_cb[252]	 "music_app_terminate_cb"
05-28 08:18:54.000+0900 E/EFL     (23827): evas_main<23827> evas_object_main.c:1292 evas_object_color_set() Evas only handles pre multiplied colors!
05-28 08:18:54.000+0900 E/EFL     (23827): evas_main<23827> evas_object_main.c:1297 evas_object_color_set() Evas only handles pre multiplied colors!
05-28 08:18:54.000+0900 E/EFL     (23827): evas_main<23827> evas_object_main.c:1287 evas_object_color_set() Evas only handles pre multiplied colors!
05-28 08:18:54.000+0900 E/EFL     (23827): evas_main<23827> evas_object_main.c:1287 evas_object_color_set() Evas only handles pre multiplied colors!
05-28 08:18:54.040+0900 F/EFL     (23827): evas_main<23827> main.c:122 evas_debug_magic_wrong() Input object is wrong type
05-28 08:18:54.040+0900 F/EFL     (23827):     Expected: 70777770 - Evas
05-28 08:18:54.040+0900 F/EFL     (23827):     Supplied: 71737723 - Evas_Object
05-28 08:18:54.060+0900 W/CRASH_MANAGER(23694): worker.c: worker_job(1189) > 112382768656c143276873
