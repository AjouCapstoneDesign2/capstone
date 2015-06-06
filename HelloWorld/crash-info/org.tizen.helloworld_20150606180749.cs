S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: helloworld
PID: 21250
Date: 2015-06-06 18:07:49+0900
Executable File Path: /opt/usr/apps/org.tizen.helloworld/bin/helloworld
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x10

Register Information
r0   = 0x00000010, r1   = 0xb1b22c68
r2   = 0x00000006, r3   = 0x0000000f
r4   = 0x000000ef, r5   = 0x00000001
r6   = 0x00000010, r7   = 0x00000012
r8   = 0x00000011, r9   = 0xb3145710
r10  = 0xb4dac164, fp   = 0x00000001
ip   = 0x0000000f, sp   = 0xbeaecb5c
lr   = 0xb4da1f11, pc   = 0xb6c9e0e4
cpsr = 0x20000010

Memory Information
MemTotal:   730748 KB
MemFree:     96548 KB
Buffers:     48696 KB
Cached:     244560 KB
VmPeak:      92564 KB
VmSize:      92560 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       21052 KB
VmRSS:       21048 KB
VmData:      42424 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       24112 KB
VmPTE:          64 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 21250 TID = 21250
21250 21252 21253 

Maps Information
b3401000 b3c00000 rwxp [stack:21253]
b3d03000 b3d06000 r-xp /usr/lib/evas/modules/loaders/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
b3d0e000 b3d10000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3d27000 b3d28000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3d30000 b3d37000 r-xp /usr/lib/libfeedback.so.0.1.4
b3d57000 b3d58000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3d60000 b3d61000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3d69000 b3d80000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3d8c000 b3d90000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3d99000 b3da3000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3dad000 b45ac000 rwxp [stack:21252]
b48dd000 b49a7000 r-xp /usr/lib/libCOREGL.so.4.0
b49b8000 b49bd000 r-xp /usr/lib/libcapi-media-tool.so.0.1.3
b49c5000 b49c7000 r-xp /usr/lib/libiniparser.so.0
b49d1000 b49d3000 r-xp /usr/lib/libdri2.so.0.0.0
b49db000 b49e2000 r-xp /usr/lib/libtbm.so.1.0.0
b49ea000 b49f1000 r-xp /usr/lib/libdrm.so.2.4.0
b49fa000 b4a02000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4a0a000 b4a0f000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4a17000 b4a1c000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4a25000 b4a26000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4a2f000 b4a47000 r-xp /usr/lib/libpng12.so.0.50.0
b4a4f000 b4a52000 r-xp /usr/lib/libEGL.so.1.4
b4a5a000 b4a68000 r-xp /usr/lib/libGLESv2.so.2.0
b4a71000 b4a75000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4a7e000 b4a87000 r-xp /usr/lib/libmdm-common.so.1.0.45
b4a8f000 b4bce000 r-xp /usr/lib/libicui18n.so.51.1
b4bde000 b4be6000 r-xp /usr/lib/libui-extension.so.0.1.0
b4be7000 b4bea000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b4bf2000 b4bf5000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.22
b4bfd000 b4cb3000 r-xp /usr/lib/libcairo.so.2.11200.14
b4cbe000 b4cd0000 r-xp /usr/lib/libtts.so
b4cd8000 b4ceb000 r-xp /usr/lib/libmdm.so.1.0.88
b4cf3000 b4cf6000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b4cfe000 b4d14000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4d1c000 b4d4b000 r-xp /usr/lib/libbluetooth-api.so.1.0.0
b4d54000 b4d5b000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.4
b4d64000 b4d81000 r-xp /usr/lib/libcapi-network-bluetooth.so.0.1.52
b4d8b000 b4d95000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnueabi-armv7l-1.7.99/module.so
b4d9e000 b4da4000 r-xp /opt/usr/apps/org.tizen.helloworld/bin/helloworld
b4dad000 b4db7000 r-xp /lib/libnss_files-2.13.so
b4dc0000 b4dd2000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4dda000 b4df0000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4df8000 b4ec6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4edd000 b4f01000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4f0a000 b4f10000 r-xp /usr/lib/libappsvc.so.0.1.0
b4f18000 b4f26000 r-xp /usr/lib/libail.so.0.1.0
b4f2e000 b4f30000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.3
b4f39000 b4f3e000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.3
b4f47000 b4f49000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4f51000 b4f52000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b4f5b000 b4f5f000 r-xp /usr/lib/libogg.so.0.7.1
b4f67000 b4f89000 r-xp /usr/lib/libvorbis.so.0.4.3
b4f91000 b5075000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b5089000 b50ba000 r-xp /usr/lib/libFLAC.so.8.2.0
b5a54000 b5ae8000 r-xp /usr/lib/libstdc++.so.6.0.16
b5afb000 b5afd000 r-xp /usr/lib/libXau.so.6.0.0
b5b05000 b5b0f000 r-xp /usr/lib/libspdy.so.0.0.0
b5b18000 b5b64000 r-xp /usr/lib/libssl.so.1.0.0
b5b71000 b5b9f000 r-xp /usr/lib/libidn.so.11.5.44
b5ba7000 b5bb1000 r-xp /usr/lib/libcares.so.2.1.0
b5bb9000 b5bda000 r-xp /usr/lib/libexif.so.12.3.3
b5bed000 b5c32000 r-xp /usr/lib/libsndfile.so.1.0.25
b5c40000 b5c56000 r-xp /lib/libexpat.so.1.5.2
b5c5f000 b5d44000 r-xp /usr/lib/libicuuc.so.51.1
b5d59000 b5d8d000 r-xp /usr/lib/libicule.so.51.1
b5d96000 b5da9000 r-xp /usr/lib/libxcb.so.1.1.0
b5db1000 b5dee000 r-xp /usr/lib/libcurl.so.4.3.0
b5df7000 b5e00000 r-xp /usr/lib/libethumb.so.1.7.99
b5e09000 b5e0b000 r-xp /usr/lib/libctxdata.so.0.0.0
b5e13000 b5e20000 r-xp /usr/lib/libremix.so.0.0.0
b5e28000 b5e29000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5e31000 b5e48000 r-xp /usr/lib/liblua-5.1.so
b5e51000 b5e58000 r-xp /usr/lib/libembryo.so.1.7.99
b5e60000 b5e83000 r-xp /usr/lib/libjpeg.so.8.0.2
b5e9b000 b5ef1000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5efe000 b5f51000 r-xp /usr/lib/libfreetype.so.6.8.1
b5f5c000 b5f84000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5f85000 b5fcb000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b5fd4000 b5fe7000 r-xp /usr/lib/libfribidi.so.0.3.1
b5fef000 b5ff2000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b5ffa000 b5ffe000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6006000 b600b000 r-xp /usr/lib/libecore_fb.so.1.7.99
b6014000 b601e000 r-xp /usr/lib/libXext.so.6.4.0
b6026000 b6107000 r-xp /usr/lib/libX11.so.6.3.0
b6112000 b6115000 r-xp /usr/lib/libXtst.so.6.1.0
b611d000 b6123000 r-xp /usr/lib/libXrender.so.1.3.0
b612b000 b6130000 r-xp /usr/lib/libXrandr.so.2.2.0
b6138000 b6139000 r-xp /usr/lib/libXinerama.so.1.0.0
b6142000 b614a000 r-xp /usr/lib/libXi.so.6.1.0
b614b000 b614e000 r-xp /usr/lib/libXfixes.so.3.1.0
b6156000 b6158000 r-xp /usr/lib/libXgesture.so.7.0.0
b6160000 b6162000 r-xp /usr/lib/libXcomposite.so.1.0.0
b616a000 b616b000 r-xp /usr/lib/libXdamage.so.1.1.0
b6174000 b617a000 r-xp /usr/lib/libXcursor.so.1.0.2
b6183000 b619c000 r-xp /usr/lib/libecore_con.so.1.7.99
b61a6000 b61ac000 r-xp /usr/lib/libecore_imf.so.1.7.99
b61b4000 b61bc000 r-xp /usr/lib/libethumb_client.so.1.7.99
b61c4000 b61cd000 r-xp /usr/lib/libedbus.so.1.7.99
b61d5000 b6232000 r-xp /usr/lib/libedje.so.1.7.99
b623b000 b624c000 r-xp /usr/lib/libecore_input.so.1.7.99
b6254000 b6259000 r-xp /usr/lib/libecore_file.so.1.7.99
b6261000 b627a000 r-xp /usr/lib/libeet.so.1.7.99
b628b000 b628f000 r-xp /usr/lib/libappcore-common.so.1.1
b6297000 b635e000 r-xp /usr/lib/libevas.so.1.7.99
b6383000 b63a4000 r-xp /usr/lib/libecore_evas.so.1.7.99
b63ad000 b63dc000 r-xp /usr/lib/libecore_x.so.1.7.99
b63e6000 b651d000 r-xp /usr/lib/libelementary.so.1.7.99
b6533000 b6534000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b653c000 b6540000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.3
b654b000 b654e000 r-xp /lib/libgpg-error.so.0.5.0
b6556000 b65ae000 r-xp /usr/lib/libgcrypt.so.11.5.3
b65b8000 b65e4000 r-xp /usr/lib/libsystemd.so.0.0.1
b65ed000 b65ef000 r-xp /usr/lib/journal/libjournal.so.0.1.0
b65f8000 b66c3000 r-xp /usr/lib/libxml2.so.2.7.8
b66d1000 b66e1000 r-xp /lib/libresolv-2.13.so
b66e5000 b66fb000 r-xp /lib/libz.so.1.2.5
b6703000 b6705000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b670d000 b6712000 r-xp /usr/lib/libffi.so.5.0.10
b671b000 b671c000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6724000 b6727000 r-xp /lib/libattr.so.1.1.0
b672f000 b6732000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b673a000 b6741000 r-xp /usr/lib/libvconf.so.0.2.45
b674a000 b68f1000 r-xp /usr/lib/libcrypto.so.1.0.0
b6913000 b6929000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6931000 b699a000 r-xp /lib/libm-2.13.so
b69a3000 b69e3000 r-xp /usr/lib/libeina.so.1.7.99
b69ec000 b6a20000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b6a29000 b6afd000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b6b09000 b6b0e000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b6b17000 b6b1d000 r-xp /lib/librt-2.13.so
b6b26000 b6b2d000 r-xp /lib/libcrypt-2.13.so
b6b5d000 b6b60000 r-xp /lib/libcap.so.2.21
b6b68000 b6b6a000 r-xp /usr/lib/libiri.so
b6b72000 b6b91000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b6b99000 b6baf000 r-xp /usr/lib/libecore.so.1.7.99
b6bc5000 b6bca000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6bd3000 b6bea000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6bf3000 b6bfe000 r-xp /lib/libunwind.so.8.0.1
b6c2b000 b6d46000 r-xp /lib/libc-2.13.so
b6d54000 b6d5c000 r-xp /lib/libgcc_s-4.6.4.so.1
b6d64000 b6d8e000 r-xp /usr/lib/libdbus-1.so.3.7.2
b6d97000 b6d9a000 r-xp /usr/lib/libbundle.so.0.1.22
b6da2000 b6da4000 r-xp /lib/libdl-2.13.so
b6dad000 b6db0000 r-xp /usr/lib/libsmack.so.1.0.0
b6db8000 b6e88000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b6e89000 b6eee000 r-xp /usr/lib/libsqlite3.so.0.8.6
b6ef8000 b6f0a000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6f12000 b6f26000 r-xp /lib/libpthread-2.13.so
b6f31000 b6f33000 r-xp /usr/lib/libdlog.so.0.0.0
b6f3b000 b6f46000 r-xp /usr/lib/libaul.so.0.1.0
b6f58000 b6f5b000 r-xp /usr/lib/libappcore-efl.so.1.1
b6f65000 b6f69000 r-xp /usr/lib/libsys-assert.so
b6f72000 b6f8f000 r-xp /lib/ld-2.13.so
b6f98000 b6f9d000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
b8ae5000 b8b0f000 rw-p [heap]
b8b0f000 b8c2d000 rw-p [heap]
beacd000 beaee000 rwxp [stack]
beacd000 beaee000 rwxp [stack]
End of Maps Information

Callstack Information (PID:21250)
Call Stack Count: 2
 0: strncpy + 0x2c (0xb6c9e0e4) [/lib/libc.so.6] + 0x730e4
 1: refresh_clicked_cb + 0xb4 (0xb4da1f11) [/opt/usr/apps/org.tizen.helloworld/bin/helloworld] + 0x3f11
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
 mkdir failed. appdir=[/usr/apps/org.tizen.helloworld/shared], errno=[2][No such file or directory]
06-06 18:07:23.566+0900 E/rpm-installer(21134): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/usr/apps/org.tizen.helloworld/shared]
06-06 18:07:23.566+0900 E/rpm-installer(21134): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/opt/usr/apps/org.tizen.helloworld/shared/data]
06-06 18:07:23.566+0900 E/rpm-installer(21134): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1406) > skip! empty dirpath=[/usr/apps/org.tizen.helloworld/shared/res]
06-06 18:07:23.566+0900 E/rpm-installer(21134): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.helloworld/tizen-manifest.xml]
06-06 18:07:23.566+0900 E/rpm-installer(21134): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.helloworld/author-signature.xml]
06-06 18:07:23.566+0900 E/rpm-installer(21134): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/apps/org.tizen.helloworld/signature1.xml]
06-06 18:07:23.566+0900 E/rpm-installer(21134): coretpk-installer.c: _coretpk_installer_apply_file_policy(1391) > skip! empty filepath=[/usr/share/packages/org.tizen.helloworld.xml]
06-06 18:07:24.106+0900 E/rpm-installer(21134): coretpk-installer.c: _coretpk_installer_get_smack_label_access(964) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.helloworld/shared/data]))
06-06 18:07:24.636+0900 I/Tizen::Net::Wifi( 1165): (1072) > _WifiService is not registered.
06-06 18:07:24.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 18:07:24.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 18:07:24.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 18:07:24.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 18:07:24.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 18:07:24.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 224 331 5 28 25"
06-06 18:07:24.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
06-06 18:07:24.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 230 387 5 28 25"
06-06 18:07:24.646+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 18:07:24.646+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 18:07:24.646+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 18:07:24.646+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 18:07:24.646+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 18:07:24.646+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 224 651 5 28 25"
06-06 18:07:24.646+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
06-06 18:07:24.646+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 230 707 5 28 25"
06-06 18:07:25.636+0900 I/Tizen::Net::Wifi( 1165): (1072) > _WifiService is not registered.
06-06 18:07:25.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 18:07:25.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 18:07:25.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 18:07:25.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 18:07:25.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 18:07:25.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 224 331 5 28 25"
06-06 18:07:25.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
06-06 18:07:25.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 230 387 5 28 25"
06-06 18:07:25.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 18:07:25.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 18:07:25.646+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 18:07:25.646+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 18:07:25.646+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 18:07:25.646+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 224 651 5 28 25"
06-06 18:07:25.646+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
06-06 18:07:25.646+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 230 707 5 28 25"
06-06 18:07:26.206+0900 E/PKGMGR_INFO(21134): pkgmgrinfo_feature.c: pkgmgrinfo_updateinfo_remove(528) > (strstr(vconf_str, pkgid_is) == NULL) pkgid is already removed
06-06 18:07:26.206+0900 E/PKGMGR_INSTALLER(21134): pkgmgr_installer.c: __send_event(114) > fail to remove update-service
06-06 18:07:26.206+0900 I/Tizen::App( 1048): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.helloworld, key: install_percent, val: 100
06-06 18:07:26.206+0900 I/Tizen::App( 1048): (119) > InstallationInProgress [100]
06-06 18:07:26.206+0900 I/Tizen::App( 1048): (1584) > Package = [org.tizen.helloworld], Key = [install_percent], Value = [100], install = [1]
06-06 18:07:26.226+0900 I/Tizen::App( 1048): (1894) > PackageEventHandler - req: 1, pkg_type: rpm, pkg_name: org.tizen.helloworld, key: end, val: ok
06-06 18:07:26.226+0900 I/Tizen::App( 1048): (78) > Installation is Completed. [Package = org.tizen.helloworld]
06-06 18:07:26.226+0900 I/Tizen::App( 1048): (663) > Enter. package(org.tizen.helloworld), installationResult(0)
06-06 18:07:26.226+0900 E/cluster-home(  587): mainmenu-package-manager.cpp: OnClientListenCb(535) >  #Step 1
06-06 18:07:26.226+0900 E/cluster-home(  587): mainmenu-package-manager.cpp: OnClientListenCb(539) >  #Step 2
06-06 18:07:26.226+0900 E/cluster-home(  587): mainmenu-package-manager.cpp: _GetAppIds(344) >  BEGIN
06-06 18:07:26.236+0900 I/Tizen::App( 1048): (1360) > package(org.tizen.helloworld), version(1.0.0), type(rpm), displayName(helloworld), uninstallable(1), downloaded(1), updated(0), preloaded(0)movable(1), externalStorage(0), mainApp(org.tizen.helloworld), storeClient(), appRootPath(/opt/usr/apps/org.tizen.helloworld)
06-06 18:07:26.256+0900 I/Tizen::App( 1048): (483) > pkgmgrinfo_appinfo_get_appid(): app = [org.tizen.helloworld]
06-06 18:07:26.266+0900 I/Tizen::App( 1048): (416) > appName = [helloworld]
06-06 18:07:26.266+0900 I/Tizen::App( 1048): (509) > exe = [/opt/usr/apps/org.tizen.helloworld/bin/helloworld], displayName = [helloworld], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-06 18:07:26.266+0900 E/PKGMGR_INFO( 1048): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_get_list(717) > (component == PMINFO_SVC_APP) PMINFO_SVC_APP is done
06-06 18:07:26.266+0900 I/Tizen::App( 1048): (675) > Application count(1) in this package
06-06 18:07:26.266+0900 I/Tizen::App( 1048): (855) > Enter.
06-06 18:07:26.286+0900 I/Tizen::App( 1048): (695) > Exit.
06-06 18:07:26.286+0900 I/Tizen::App( 1048): (1584) > Package = [org.tizen.helloworld], Key = [end], Value = [ok], install = [96]
06-06 18:07:26.286+0900 I/Tizen::App( 1048): (416) > appName = [helloworld]
06-06 18:07:26.286+0900 I/Tizen::App( 1048): (509) > exe = [/opt/usr/apps/org.tizen.helloworld/bin/helloworld], displayName = [helloworld], mainApp = [1], menuIconVisible = [0], serviceApp = [0]
06-06 18:07:26.286+0900 I/Tizen::App( 1048): (2343) > info file is not existed. [/opt/usr/apps/org.tizen./info/org.tizen.helloworld.info]
06-06 18:07:26.286+0900 I/Tizen::App( 1048): (131) > Enter
06-06 18:07:26.286+0900 I/Tizen::App( 1048): (137) > org.tizen.helloworld does not have launch condition
06-06 18:07:26.296+0900 I/Tizen::App( 1048): (898) > Exit.
06-06 18:07:26.306+0900 E/cluster-home(  587): mainmenu-package-manager.cpp: _PkgMgrAppInfoGetListCb(246) >  ##### [org.tizen.helloworld]
06-06 18:07:26.306+0900 E/cluster-home(  587): mainmenu-package-manager.cpp: _GetAppIds(365) >  ##### [org.tizen.helloworld]
06-06 18:07:26.306+0900 E/cluster-home(  587): mainmenu-package-manager.cpp: _GetAppIds(369) >  END
06-06 18:07:26.306+0900 E/cluster-home(  587): mainmenu-package-manager.cpp: _DoPkgJob(448) >  #Step 3 size[1]
06-06 18:07:26.306+0900 E/cluster-home(  587): mainmenu-package-manager.cpp: _DoPkgJob(452) >  appId[org.tizen.helloworld]
06-06 18:07:26.316+0900 E/cluster-home(  587): mainmenu-package-manager.cpp: _GetAppInfo(941) >  AppId[org.tizen.helloworld] Name[helloworld] Icon[/opt/usr/apps/org.tizen.helloworld/shared/res/Koala.png] enable[1] system[0]
06-06 18:07:26.326+0900 E/cluster-home(  587): mainmenu-package-manager.cpp: GetAppInfo(595) >  Find a App Info AppId[org.tizen.helloworld] Name[helloworld] Icon[/opt/usr/apps/org.tizen.helloworld/shared/res/Koala.png] enable[1] system[0]
06-06 18:07:28.326+0900 W/AUL_AMD (  445): amd_request.c: __request_handler(601) > __request_handler: 0
06-06 18:07:28.336+0900 I/AUL     (  445): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /usr/bin/launch_app, ret : 0
06-06 18:07:28.346+0900 I/AUL     (  445): menu_db_util.h: _get_app_info_from_db_by_apppath(240) > path : /bin/bash, ret : 0
06-06 18:07:28.346+0900 E/AUL_AMD (  445): amd_appinfo.c: appinfo_get_value(791) > appinfo get value: Invalid argument, 24
06-06 18:07:28.426+0900 I/CAPI_APPFW_APPLICATION(21210): app_main.c: ui_app_main(699) > app_efl_main
06-06 18:07:28.456+0900 I/UXT     (21210): uxt_object_manager.cpp: on_initialized(287) > Initialized.
06-06 18:07:28.476+0900 E/RESOURCED(  755): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 408
06-06 18:07:28.476+0900 I/Tizen::App( 1147): (733) > Finished invoking application event listener for org.tizen.helloworld, 21210.
06-06 18:07:28.496+0900 I/Tizen::App( 1048): (499) > LaunchedApp(org.tizen.helloworld)
06-06 18:07:28.496+0900 I/Tizen::App( 1048): (733) > Finished invoking application event listener for org.tizen.helloworld, 21210.
06-06 18:07:28.536+0900 I/CAPI_APPFW_APPLICATION(21210): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
06-06 18:07:28.556+0900 I/APAMS   (21210): helloworld.c: blue_setting(1014) > [blue_setting] BLE discovering starts.
06-06 18:07:28.666+0900 I/APAMS   (21210): helloworld.c: blue_setting(1047) > [blue_setting] BT was already enabled.
06-06 18:07:28.786+0900 E/EFL     (21210): evas_main<21210> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
06-06 18:07:28.796+0900 E/EFL     (21210): evas_main<21210> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
06-06 18:07:28.916+0900 E/EFL     (21210): evas_main<21210> evas_object_main.c:1322 evas_object_color_set() Evas only handles pre multiplied colors!
06-06 18:07:28.916+0900 E/EFL     (21210): evas_main<21210> evas_object_main.c:1327 evas_object_color_set() Evas only handles pre multiplied colors!
06-06 18:07:28.916+0900 E/EFL     (21210): evas_main<21210> evas_object_main.c:1317 evas_object_color_set() Evas only handles pre multiplied colors!
06-06 18:07:28.916+0900 E/EFL     (21210): evas_main<21210> evas_object_main.c:1317 evas_object_color_set() Evas only handles pre multiplied colors!
06-06 18:07:29.026+0900 I/CAPI_APPFW_APPLICATION(21210): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-06 18:07:29.036+0900 I/APP_CORE(21210): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
06-06 18:07:29.036+0900 I/APP_CORE(21210): appcore-efl.c: __do_app(511) > [APP 21210] Initial Launching, call the resume_cb
06-06 18:07:29.036+0900 I/CAPI_APPFW_APPLICATION(21210): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-06 18:07:29.066+0900 W/PROCESSMGR(  344): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=21210
06-06 18:07:29.066+0900 W/APP_CORE(21210): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00002
06-06 18:07:29.136+0900 I/MALI    (  587): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb8c42c18] swap changed from sync to async
06-06 18:07:29.176+0900 I/Tizen::System( 1147): (259) > Active app [org.tizen.], current [com.samsun] 
06-06 18:07:29.186+0900 I/Tizen::Io( 1147): (729) > Entry not found
06-06 18:07:29.196+0900 I/Tizen::System( 1147): (157) > change brightness system value.
06-06 18:07:29.236+0900 I/CAPI_APPFW_APPLICATION(  587): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-06 18:07:29.236+0900 E/cluster-home(  587): homescreen-main.cpp: app_pause(355) >  app pause
06-06 18:07:29.246+0900 W/AUL_AMD (  445): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-06 18:07:29.246+0900 W/AUL_AMD (  445): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-06 18:07:29.636+0900 I/Tizen::Net::Wifi( 1165): (1072) > _WifiService is not registered.
06-06 18:07:29.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 18:07:29.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 18:07:29.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 18:07:29.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 18:07:29.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 18:07:29.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 224 331 5 28 25"
06-06 18:07:29.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
06-06 18:07:29.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 230 387 5 28 25"
06-06 18:07:29.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 18:07:29.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 18:07:29.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 18:07:29.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 18:07:29.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 18:07:29.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 224 651 5 28 25"
06-06 18:07:29.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
06-06 18:07:29.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 230 707 5 28 25"
06-06 18:07:29.716+0900 I/APAMS   (21210): <In the CS of the BLE Thread
06-06 18:07:29.716+0900 E/APAMS   (21210): BLE Thread is running... (For 0 sec)
06-06 18:07:29.866+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:29.866+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:4D:9E
06-06 18:07:29.866+0900 I/APAMS   (21210): Device RSSI: -82
06-06 18:07:29.876+0900 I/APAMS   (21210): howd? trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-82&phoneid=1
06-06 18:07:30.006+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:30.006+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:39:58
06-06 18:07:30.006+0900 I/APAMS   (21210): Device RSSI: -62
06-06 18:07:30.006+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-62&phoneid=1
06-06 18:07:30.046+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:30.046+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:3A:DC
06-06 18:07:30.046+0900 I/APAMS   (21210): Device RSSI: -53
06-06 18:07:30.056+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-53&phoneid=1
06-06 18:07:30.126+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:30.126+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:39:58
06-06 18:07:30.126+0900 I/APAMS   (21210): Device RSSI: -44
06-06 18:07:30.126+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-44&phoneid=1
06-06 18:07:30.216+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:30.216+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:4D:9E
06-06 18:07:30.216+0900 I/APAMS   (21210): Device RSSI: -57
06-06 18:07:30.226+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-57&phoneid=1
06-06 18:07:30.296+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:30.296+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:06:82
06-06 18:07:30.296+0900 I/APAMS   (21210): Device RSSI: -41
06-06 18:07:30.296+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-41&phoneid=1
06-06 18:07:30.396+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:30.396+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:39:58
06-06 18:07:30.396+0900 I/APAMS   (21210): Device RSSI: -61
06-06 18:07:30.396+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-61&phoneid=1
06-06 18:07:30.556+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:30.556+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:06:82
06-06 18:07:30.556+0900 I/APAMS   (21210): Device RSSI: -38
06-06 18:07:30.556+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-38&phoneid=1
06-06 18:07:30.706+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:30.706+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:3A:DC
06-06 18:07:30.706+0900 I/APAMS   (21210): Device RSSI: -46
06-06 18:07:30.706+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-46&phoneid=1
06-06 18:07:30.816+0900 I/APAMS   (21210): <In the CS of the BLE Thread
06-06 18:07:30.816+0900 E/APAMS   (21210): BLE Thread is running... (For 1 sec)
06-06 18:07:30.816+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:30.816+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:06:82
06-06 18:07:30.816+0900 I/APAMS   (21210): Device RSSI: -61
06-06 18:07:30.816+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-61&phoneid=1
06-06 18:07:30.886+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:30.886+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:4D:9E
06-06 18:07:30.886+0900 I/APAMS   (21210): Device RSSI: -71
06-06 18:07:30.896+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-71&phoneid=1
06-06 18:07:30.966+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:30.966+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:3A:DC
06-06 18:07:30.966+0900 I/APAMS   (21210): Device RSSI: -51
06-06 18:07:30.966+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-51&phoneid=1
06-06 18:07:31.066+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:31.066+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:06:82
06-06 18:07:31.066+0900 I/APAMS   (21210): Device RSSI: -37
06-06 18:07:31.066+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-37&phoneid=1
06-06 18:07:31.136+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:31.136+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:39:58
06-06 18:07:31.136+0900 I/APAMS   (21210): Device RSSI: -45
06-06 18:07:31.146+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-45&phoneid=1
06-06 18:07:31.286+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:31.286+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:4D:9E
06-06 18:07:31.286+0900 I/APAMS   (21210): Device RSSI: -71
06-06 18:07:31.286+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-71&phoneid=1
06-06 18:07:31.376+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:31.376+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:3A:DC
06-06 18:07:31.376+0900 I/APAMS   (21210): Device RSSI: -64
06-06 18:07:31.376+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-64&phoneid=1
06-06 18:07:31.446+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:31.446+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:06:82
06-06 18:07:31.446+0900 I/APAMS   (21210): Device RSSI: -47
06-06 18:07:31.446+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-47&phoneid=1
06-06 18:07:31.486+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:31.486+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:39:58
06-06 18:07:31.486+0900 I/APAMS   (21210): Device RSSI: -56
06-06 18:07:31.496+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-56&phoneid=1
06-06 18:07:31.816+0900 I/APAMS   (21210): <In the CS of the BLE Thread
06-06 18:07:31.816+0900 E/APAMS   (21210): BLE Thread is running... (For 2 sec)
06-06 18:07:31.906+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:31.906+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:4D:9E
06-06 18:07:31.906+0900 I/APAMS   (21210): Device RSSI: -93
06-06 18:07:31.916+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-93&phoneid=1
06-06 18:07:32.076+0900 W/CAM_APP (17146): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:07:32.136+0900 W/CAM_APP (17146): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:07:32.226+0900 I/APAMS   (21210): z﻿﻿a
06-06 18:07:32.296+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:32.296+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:3A:DC
06-06 18:07:32.296+0900 I/APAMS   (21210): Device RSSI: -76
06-06 18:07:32.296+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-76&phoneid=1
06-06 18:07:32.346+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:32.346+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:06:82
06-06 18:07:32.346+0900 I/APAMS   (21210): Device RSSI: -43
06-06 18:07:32.346+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-43&phoneid=1
06-06 18:07:32.376+0900 W/CAM_APP (17146): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:07:32.486+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:32.486+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:39:58
06-06 18:07:32.486+0900 I/APAMS   (21210): Device RSSI: -56
06-06 18:07:32.486+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-56&phoneid=1
06-06 18:07:32.546+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:32.546+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:4D:9E
06-06 18:07:32.546+0900 I/APAMS   (21210): Device RSSI: -70
06-06 18:07:32.546+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-70&phoneid=1
06-06 18:07:32.606+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:32.606+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:3A:DC
06-06 18:07:32.606+0900 I/APAMS   (21210): Device RSSI: -73
06-06 18:07:32.606+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-73&phoneid=1
06-06 18:07:32.616+0900 I/Tizen::Net::Wifi( 1165): (1072) > _WifiService is not registered.
06-06 18:07:32.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 18:07:32.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 18:07:32.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 18:07:32.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 18:07:32.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 18:07:32.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 224 331 5 28 25"
06-06 18:07:32.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
06-06 18:07:32.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 230 387 5 28 25"
06-06 18:07:32.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 18:07:32.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 18:07:32.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 18:07:32.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 18:07:32.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 18:07:32.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 224 651 5 28 25"
06-06 18:07:32.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
06-06 18:07:32.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 230 707 5 28 25"
06-06 18:07:32.666+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:32.666+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:06:82
06-06 18:07:32.666+0900 I/APAMS   (21210): Device RSSI: -40
06-06 18:07:32.666+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-40&phoneid=1
06-06 18:07:32.726+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:32.726+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:39:58
06-06 18:07:32.726+0900 I/APAMS   (21210): Device RSSI: -63
06-06 18:07:32.726+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-63&phoneid=1
06-06 18:07:32.786+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:32.786+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:4D:9E
06-06 18:07:32.786+0900 I/APAMS   (21210): Device RSSI: -79
06-06 18:07:32.786+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-79&phoneid=1
06-06 18:07:32.846+0900 I/APAMS   (21210): <In the CS of the BLE Thread
06-06 18:07:32.846+0900 E/APAMS   (21210): BLE Thread is running... (For 3 sec)
06-06 18:07:32.996+0900 I/APAMS   (21210): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:32.996+0900 I/APAMS   (21210): Device Address: 78:A5:04:4F:3A:DC
06-06 18:07:32.996+0900 I/APAMS   (21210): Device RSSI: -46
06-06 18:07:33.006+0900 I/APAMS   (21210): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-46&phoneid=1
06-06 18:07:33.266+0900 I/APAMS   (21210): z﻿﻿a
06-06 18:07:33.456+0900 I/AUL_PAD (  461): sigchild.h: __launchpad_sig_child(142) > dead_pid = 21210 pgid = 21210
06-06 18:07:33.456+0900 I/AUL_PAD (  461): sigchild.h: __sigchild_action(123) > dead_pid(21210)
06-06 18:07:33.456+0900 I/AUL_PAD (  461): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-06 18:07:33.456+0900 I/AUL_PAD (  461): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-06 18:07:33.466+0900 W/AUL_AMD (  445): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-06 18:07:33.466+0900 W/AUL_AMD (  445): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-06 18:07:33.526+0900 W/PROCESSMGR(  344): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=587
06-06 18:07:33.546+0900 I/Tizen::System( 1147): (246) > Terminated app [org.tizen.helloworld]
06-06 18:07:33.546+0900 I/Tizen::Io( 1147): (729) > Entry not found
06-06 18:07:33.546+0900 I/Tizen::App( 1048): (243) > App[org.tizen.helloworld] pid[21210] terminate event is forwarded
06-06 18:07:33.546+0900 I/Tizen::System( 1048): (256) > osp.accessorymanager.service provider is found.
06-06 18:07:33.546+0900 I/Tizen::System( 1048): (196) > Accessory Owner is removed [org.tizen.helloworld, 21210, ]
06-06 18:07:33.546+0900 I/Tizen::System( 1048): (256) > osp.system.service provider is found.
06-06 18:07:33.546+0900 I/Tizen::App( 1048): (506) > TerminatedApp(org.tizen.helloworld)
06-06 18:07:33.546+0900 I/Tizen::App( 1048): (512) > Not registered pid(21210)
06-06 18:07:33.546+0900 I/Tizen::App( 1048): (782) > Finished invoking application event listener for org.tizen.helloworld, 21210.
06-06 18:07:33.556+0900 I/CAPI_APPFW_APPLICATION(  587): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-06 18:07:33.556+0900 E/cluster-home(  587): homescreen-main.cpp: app_resume(422) >  app resume
06-06 18:07:33.556+0900 I/AUL_AMD (  445): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 21210
06-06 18:07:33.606+0900 I/Tizen::System( 1147): (157) > change brightness system value.
06-06 18:07:33.606+0900 I/Tizen::App( 1147): (782) > Finished invoking application event listener for org.tizen.helloworld, 21210.
06-06 18:07:33.656+0900 I/Tizen::System( 1147): (259) > Active app [com.samsun], current [org.tizen.] 
06-06 18:07:33.666+0900 W/CRASH_MANAGER(21233): worker.c: worker_job(1198) > 112121068656c1433581653
06-06 18:07:33.676+0900 I/Tizen::Io( 1147): (729) > Entry not found
06-06 18:07:33.696+0900 W/CAM_APP (17146): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:07:33.716+0900 I/Tizen::System( 1147): (157) > change brightness system value.
06-06 18:07:34.056+0900 W/CAM_APP (17146): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:07:34.116+0900 W/CAM_APP (17146): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:07:34.616+0900 I/Tizen::Net::Wifi( 1165): (1072) > _WifiService is not registered.
06-06 18:07:34.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 18:07:34.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 18:07:34.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 18:07:34.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 18:07:34.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 18:07:34.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 224 331 5 28 25"
06-06 18:07:34.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
06-06 18:07:34.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 230 387 5 28 25"
06-06 18:07:34.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 18:07:34.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 18:07:34.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 18:07:34.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 18:07:34.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 18:07:34.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 224 651 5 28 25"
06-06 18:07:34.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
06-06 18:07:34.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 230 707 5 28 25"
06-06 18:07:35.636+0900 I/Tizen::Net::Wifi( 1165): (1072) > _WifiService is not registered.
06-06 18:07:35.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 18:07:35.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 18:07:35.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 18:07:35.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 18:07:35.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 18:07:35.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 224 331 5 28 25"
06-06 18:07:35.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
06-06 18:07:35.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 230 387 5 28 25"
06-06 18:07:35.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 18:07:35.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 18:07:35.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 18:07:35.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 18:07:35.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 18:07:35.636+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 224 651 5 28 25"
06-06 18:07:35.646+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
06-06 18:07:35.646+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 230 707 5 28 25"
06-06 18:07:35.936+0900 I/MALI    (  587): egl_platform_x11_tizen.c: tizen_update_native_surface_private(172) > [EGL-X11] surface->[0xb8c42c18] swap changed from async to sync
06-06 18:07:35.966+0900 W/AUL_AMD (  445): amd_request.c: __request_handler(601) > __request_handler: 1
06-06 18:07:36.076+0900 I/CAPI_APPFW_APPLICATION(21250): app_main.c: ui_app_main(699) > app_efl_main
06-06 18:07:36.086+0900 E/RESOURCED(  755): proc-main.c: resourced_proc_status_change(614) > [resourced_proc_status_change,614] available memory = 407
06-06 18:07:36.096+0900 I/Tizen::App( 1048): (499) > LaunchedApp(org.tizen.helloworld)
06-06 18:07:36.096+0900 I/Tizen::App( 1048): (733) > Finished invoking application event listener for org.tizen.helloworld, 21250.
06-06 18:07:36.116+0900 I/Tizen::App( 1147): (733) > Finished invoking application event listener for org.tizen.helloworld, 21250.
06-06 18:07:36.156+0900 I/UXT     (21250): uxt_object_manager.cpp: on_initialized(287) > Initialized.
06-06 18:07:36.216+0900 I/CAPI_APPFW_APPLICATION(21250): app_main.c: _ui_app_appcore_create(560) > app_appcore_create
06-06 18:07:36.266+0900 I/APAMS   (21250): helloworld.c: blue_setting(1014) > [blue_setting] BLE discovering starts.
06-06 18:07:36.426+0900 I/APAMS   (21250): helloworld.c: blue_setting(1047) > [blue_setting] BT was already enabled.
06-06 18:07:36.576+0900 E/EFL     (21250): evas_main<21250> evas_font_dir.c:70 _evas_font_init_instance() ENTER:: evas_font_init
06-06 18:07:36.596+0900 E/EFL     (21250): evas_main<21250> evas_font_dir.c:90 evas_font_init() DONE:: evas_font_init
06-06 18:07:36.696+0900 E/EFL     (21250): evas_main<21250> evas_object_main.c:1322 evas_object_color_set() Evas only handles pre multiplied colors!
06-06 18:07:36.706+0900 E/EFL     (21250): evas_main<21250> evas_object_main.c:1327 evas_object_color_set() Evas only handles pre multiplied colors!
06-06 18:07:36.706+0900 E/EFL     (21250): evas_main<21250> evas_object_main.c:1317 evas_object_color_set() Evas only handles pre multiplied colors!
06-06 18:07:36.706+0900 E/EFL     (21250): evas_main<21250> evas_object_main.c:1317 evas_object_color_set() Evas only handles pre multiplied colors!
06-06 18:07:36.836+0900 W/PROCESSMGR(  344): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=21250
06-06 18:07:36.876+0900 I/CAPI_APPFW_APPLICATION(21250): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
06-06 18:07:36.896+0900 I/MALI    (  587): egl_platform_x11_tizen.c: tizen_update_native_surface_private(181) > [EGL-X11] surface->[0xb8c42c18] swap changed from sync to async
06-06 18:07:36.906+0900 I/Tizen::System( 1147): (259) > Active app [org.tizen.], current [com.samsun] 
06-06 18:07:36.906+0900 I/Tizen::Io( 1147): (729) > Entry not found
06-06 18:07:36.926+0900 I/Tizen::System( 1147): (157) > change brightness system value.
06-06 18:07:36.936+0900 I/APP_CORE(21250): appcore-efl.c: __do_app(509) > Legacy lifecycle: 0
06-06 18:07:36.936+0900 I/APP_CORE(21250): appcore-efl.c: __do_app(511) > [APP 21250] Initial Launching, call the resume_cb
06-06 18:07:36.936+0900 I/CAPI_APPFW_APPLICATION(21250): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
06-06 18:07:36.946+0900 W/APP_CORE(21250): appcore-efl.c: __show_cb(822) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:4c00002
06-06 18:07:37.046+0900 I/CAPI_APPFW_APPLICATION(  587): app_main.c: app_appcore_pause(202) > app_appcore_pause
06-06 18:07:37.046+0900 E/cluster-home(  587): homescreen-main.cpp: app_pause(355) >  app pause
06-06 18:07:37.476+0900 I/APAMS   (21250): <In the CS of the BLE Thread
06-06 18:07:37.476+0900 E/APAMS   (21250): BLE Thread is running... (For 0 sec)
06-06 18:07:38.616+0900 I/Tizen::Net::Wifi( 1165): (1072) > _WifiService is not registered.
06-06 18:07:38.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 18:07:38.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 18:07:38.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 18:07:38.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 18:07:38.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 18:07:38.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 224 331 5 28 25"
06-06 18:07:38.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
06-06 18:07:38.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 230 387 5 28 25"
06-06 18:07:38.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 18:07:38.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 18:07:38.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 18:07:38.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 18:07:38.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 18:07:38.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 224 651 5 28 25"
06-06 18:07:38.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
06-06 18:07:38.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 230 707 5 28 25"
06-06 18:07:39.756+0900 I/APAMS   (21250): z﻿﻿a
06-06 18:07:39.796+0900 I/APAMS   (21250): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:39.796+0900 I/APAMS   (21250): Device Address: 78:A5:04:4F:39:58
06-06 18:07:39.796+0900 I/APAMS   (21250): Device RSSI: -43
06-06 18:07:39.796+0900 I/APAMS   (21250): howd? trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-43&phoneid=1
06-06 18:07:41.416+0900 I/APAMS   (21250): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:41.416+0900 I/APAMS   (21250): Device Address: 78:A5:04:4F:3A:DC
06-06 18:07:41.416+0900 I/APAMS   (21250): Device RSSI: -43
06-06 18:07:41.416+0900 I/APAMS   (21250): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-43&phoneid=1
06-06 18:07:42.966+0900 I/APAMS   (21250): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:42.966+0900 I/APAMS   (21250): Device Address: 78:A5:04:4F:06:82
06-06 18:07:42.966+0900 I/APAMS   (21250): Device RSSI: -46
06-06 18:07:42.966+0900 I/APAMS   (21250): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-46&phoneid=1
06-06 18:07:43.136+0900 I/APAMS   (21250): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:43.136+0900 I/APAMS   (21250): Device Address: 78:A5:04:4F:39:58
06-06 18:07:43.136+0900 I/APAMS   (21250): Device RSSI: -42
06-06 18:07:43.136+0900 I/APAMS   (21250): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-42&phoneid=1
06-06 18:07:43.286+0900 I/APAMS   (21250): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:43.286+0900 I/APAMS   (21250): Device Address: 78:A5:04:4F:4D:9E
06-06 18:07:43.286+0900 I/APAMS   (21250): Device RSSI: -68
06-06 18:07:43.296+0900 I/APAMS   (21250): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-68&phoneid=1
06-06 18:07:43.446+0900 I/APAMS   (21250): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:43.446+0900 I/APAMS   (21250): Device Address: 78:A5:04:4F:3A:DC
06-06 18:07:43.446+0900 I/APAMS   (21250): Device RSSI: -65
06-06 18:07:43.446+0900 I/APAMS   (21250): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-65&phoneid=1
06-06 18:07:43.986+0900 I/APAMS   (21250): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:43.986+0900 I/APAMS   (21250): Device Address: 78:A5:04:4F:39:58
06-06 18:07:43.986+0900 I/APAMS   (21250): Device RSSI: -62
06-06 18:07:43.986+0900 I/APAMS   (21250): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-62&phoneid=1
06-06 18:07:45.626+0900 I/APAMS   (21250): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:45.626+0900 I/APAMS   (21250): Device Address: 78:A5:04:4F:06:82
06-06 18:07:45.626+0900 I/APAMS   (21250): Device RSSI: -46
06-06 18:07:45.636+0900 I/APAMS   (21250): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-46&phoneid=1
06-06 18:07:45.816+0900 I/APAMS   (21250): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:45.816+0900 I/APAMS   (21250): Device Address: 78:A5:04:4F:39:58
06-06 18:07:45.816+0900 I/APAMS   (21250): Device RSSI: -61
06-06 18:07:45.816+0900 I/APAMS   (21250): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-61&phoneid=1
06-06 18:07:47.436+0900 I/APAMS   (21250): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:47.436+0900 I/APAMS   (21250): Device Address: 78:A5:04:4F:4D:9E
06-06 18:07:47.436+0900 I/APAMS   (21250): Device RSSI: -96
06-06 18:07:47.456+0900 I/APAMS   (21250): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-96&phoneid=1
06-06 18:07:47.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 449 0 25 36"
06-06 18:07:47.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 34 0 25 36"
06-06 18:07:47.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 62 0 25 36"
06-06 18:07:47.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 6 0 25 36"
06-06 18:07:47.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 418 0 28 36"
06-06 18:07:47.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 224 331 5 28 25"
06-06 18:07:47.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 359 5 28 25"
06-06 18:07:47.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 230 387 5 28 25"
06-06 18:07:47.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : battery 769 0 25 36"
06-06 18:07:47.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : wifi 33 0 25 36"
06-06 18:07:47.616+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : bluetooth 61 0 25 36"
06-06 18:07:47.616+0900 I/Tizen::Net::Wifi( 1165): (1072) > _WifiService is not registered.
06-06 18:07:47.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(387) > "Fixed Icon : RSSI 5 0 25 36"
06-06 18:07:47.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(445) > "System(Non-Fixed) Icon : silent 738 0 28 36"
06-06 18:07:47.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 224 651 5 28 25"
06-06 18:07:47.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : usb 679 5 28 25"
06-06 18:07:47.626+0900 I/indicator(  490): indicator_box_util.c: _update_display(585) > "Noti Icon : 230 707 5 28 25"
06-06 18:07:47.666+0900 I/APAMS   (21250): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:47.666+0900 I/APAMS   (21250): Device Address: 78:A5:04:4F:3A:DC
06-06 18:07:47.666+0900 I/APAMS   (21250): Device RSSI: -60
06-06 18:07:47.676+0900 I/APAMS   (21250): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-60&phoneid=1
06-06 18:07:47.846+0900 I/APAMS   (21250): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:47.846+0900 I/APAMS   (21250): Device Address: 78:A5:04:4F:06:82
06-06 18:07:47.846+0900 I/APAMS   (21250): Device RSSI: -63
06-06 18:07:47.856+0900 I/APAMS   (21250): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-63&phoneid=1
06-06 18:07:48.026+0900 I/APAMS   (21250): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:48.026+0900 I/APAMS   (21250): Device Address: 78:A5:04:4F:39:58
06-06 18:07:48.026+0900 I/APAMS   (21250): Device RSSI: -58
06-06 18:07:48.036+0900 I/APAMS   (21250): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-58&phoneid=1
06-06 18:07:48.186+0900 I/APAMS   (21250): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:48.186+0900 I/APAMS   (21250): Device Address: 78:A5:04:4F:4D:9E
06-06 18:07:48.186+0900 I/APAMS   (21250): Device RSSI: -78
06-06 18:07:48.186+0900 I/APAMS   (21250): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-78&phoneid=1
06-06 18:07:48.746+0900 I/APAMS   (21250): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:48.746+0900 I/APAMS   (21250): Device Address: 78:A5:04:4F:3A:DC
06-06 18:07:48.746+0900 I/APAMS   (21250): Device RSSI: -62
06-06 18:07:48.746+0900 I/APAMS   (21250): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-62&phoneid=1
06-06 18:07:48.926+0900 I/APAMS   (21250): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:07:48.926+0900 I/APAMS   (21250): Device Address: 78:A5:04:4F:06:82
06-06 18:07:48.926+0900 I/APAMS   (21250): Device RSSI: -63
06-06 18:07:48.926+0900 I/APAMS   (21250): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-63&phoneid=1
06-06 18:07:49.076+0900 I/APAMS   (21250): <In the CS of the BLE Thread
06-06 18:07:49.086+0900 E/APAMS   (21250): BLE Thread is running... (For 1 sec)
06-06 18:07:49.466+0900 I/APAMS   (21250): z﻿﻿a
06-06 18:07:49.556+0900 W/CRASH_MANAGER(21233): worker.c: worker_job(1198) > 112125068656c143358166
