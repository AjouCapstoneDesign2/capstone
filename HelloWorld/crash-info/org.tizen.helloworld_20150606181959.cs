S/W Version Information
Model: SM-Z130H
Tizen-Version: 2.3.0.0
Build-Number: Z130HDDU0BOB3
Build-Date: 2015.02.14 15:10:17

Crash Information
Process Name: helloworld
PID: 24956
Date: 2015-06-06 18:19:59+0900
Executable File Path: /opt/usr/apps/org.tizen.helloworld/bin/helloworld
Signal: 6
      (SIGABRT)
      si_code: -6
      signal sent by tkill (sent by pid 24956, uid 5000)

Register Information
r0   = 0x00000000, r1   = 0x0000617c
r2   = 0x00000006, r3   = 0x0000617c
r4   = 0x00000006, r5   = 0x000f5528
r6   = 0xb6d50bec, r7   = 0x0000010c
r8   = 0xb6548000, r9   = 0x00000002
r10  = 0x00000072, fp   = 0xbeaecba0
ip   = 0xb65484c0, sp   = 0xbeaec468
lr   = 0xb6c5b6bc, pc   = 0xb6c579e8
cpsr = 0x20000010

Memory Information
MemTotal:   730748 KB
MemFree:     98868 KB
Buffers:     49028 KB
Cached:     241508 KB
VmPeak:      99856 KB
VmSize:      99852 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22344 KB
VmRSS:       22340 KB
VmData:      43564 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       24112 KB
VmPTE:          70 KB
VmSwap:          0 KB

Threads Information
Threads: 3
PID = 24956 TID = 24956
24956 24957 24958 

Maps Information
b3401000 b3c00000 rwxp [stack:24958]
b3d03000 b3d06000 r-xp /usr/lib/evas/modules/loaders/jpeg/linux-gnueabi-armv7l-1.7.99/module.so
b3d0e000 b3d10000 r-xp /usr/lib/evas/modules/loaders/png/linux-gnueabi-armv7l-1.7.99/module.so
b3d27000 b3d28000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b3d30000 b3d37000 r-xp /usr/lib/libfeedback.so.0.1.4
b3d57000 b3d58000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnueabi-armv7l-1.7.99/module.so
b3d60000 b3d61000 r-xp /usr/lib/edje/modules/feedback/linux-gnueabi-armv7l-1.0.0/module.so
b3d69000 b3d80000 r-xp /usr/lib/edje/modules/elm/linux-gnueabi-armv7l-1.0.0/module.so
b3d8c000 b3d90000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b3d99000 b3da3000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnueabi-armv7l-1.7.99/module.so
b3dad000 b45ac000 rwxp [stack:24957]
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
b8b0f000 b8d48000 rw-p [heap]
beacd000 beaee000 rwxp [stack]
beacd000 beaee000 rwxp [stack]
End of Maps Information

Callstack Information (PID:24956)
Call Stack Count: 6
 0: gsignal + 0x3c (0xb6c579e8) [/lib/libc.so.6] + 0x2c9e8
 1: abort + 0x1ac (0xb6c5b6bc) [/lib/libc.so.6] + 0x306bc
 2: (0xb6c8aee4) [/lib/libc.so.6] + 0x5fee4
 3: (0xb6c958e4) [/lib/libc.so.6] + 0x6a8e4
 4: cfree + 0x9c (0xb6c9a1bc) [/lib/libc.so.6] + 0x6f1bc
 5: naviframe_pop_cb + 0x8 (0xb4da2b09) [/opt/usr/apps/org.tizen.helloworld/bin/helloworld] + 0x4b09
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
: howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-90&phoneid=1
06-06 18:19:43.066+0900 I/APAMS   (24956): <In the CS of the BLE Thread
06-06 18:19:43.066+0900 E/APAMS   (24956): BLE Thread is running... (For 19 sec)
06-06 18:19:43.136+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:43.136+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:43.136+0900 I/APAMS   (24956): Device RSSI: -65
06-06 18:19:43.146+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-65&phoneid=1
06-06 18:19:43.556+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:43.556+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:43.556+0900 I/APAMS   (24956): Device RSSI: -66
06-06 18:19:43.556+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-66&phoneid=1
06-06 18:19:43.646+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:43.646+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:43.646+0900 I/APAMS   (24956): Device RSSI: -73
06-06 18:19:43.656+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-73&phoneid=1
06-06 18:19:43.806+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:43.806+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:43.806+0900 I/APAMS   (24956): Device RSSI: -45
06-06 18:19:43.806+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-45&phoneid=1
06-06 18:19:44.096+0900 E/EFL     (24956): elementary<24956> elm_layout.c:1469 elm_layout_file_set() failed to set edje file '/opt/usr/apps/org.tizen.helloworld/res/ui_controls.edj', group 'popup_image_list_layout': No Error
06-06 18:19:44.106+0900 E/EFL     (24956): elementary<24956> elm_layout.c:833 _elm_layout_smart_content_set() could not swallow 0xb8c8cf10 into part 'elm.swallow.content'
06-06 18:19:44.136+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:44.146+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:44.146+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:44.146+0900 I/APAMS   (24956): Device RSSI: -80
06-06 18:19:44.156+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-80&phoneid=1
06-06 18:19:44.266+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:44.266+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:44.266+0900 I/APAMS   (24956): Device RSSI: -76
06-06 18:19:44.266+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-76&phoneid=1
06-06 18:19:44.346+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:44.346+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:44.346+0900 I/APAMS   (24956): Device RSSI: -94
06-06 18:19:44.346+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-94&phoneid=1
06-06 18:19:44.406+0900 I/APAMS   (24956): <In the CS of the BLE Thread
06-06 18:19:44.406+0900 E/APAMS   (24956): BLE Thread is running... (For 20 sec)
06-06 18:19:44.436+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:44.436+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:44.436+0900 I/APAMS   (24956): Device RSSI: -77
06-06 18:19:44.436+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-77&phoneid=1
06-06 18:19:44.576+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:44.576+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:44.576+0900 I/APAMS   (24956): Device RSSI: -47
06-06 18:19:44.586+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-47&phoneid=1
06-06 18:19:44.646+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:44.646+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:44.646+0900 I/APAMS   (24956): Device RSSI: -71
06-06 18:19:44.646+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-71&phoneid=1
06-06 18:19:44.706+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:44.706+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:44.706+0900 I/APAMS   (24956): Device RSSI: -86
06-06 18:19:44.716+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-86&phoneid=1
06-06 18:19:44.826+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:44.826+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:44.826+0900 I/APAMS   (24956): Device RSSI: -51
06-06 18:19:44.826+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-51&phoneid=1
06-06 18:19:44.946+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:44.946+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:44.946+0900 I/APAMS   (24956): Device RSSI: -77
06-06 18:19:44.946+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-77&phoneid=1
06-06 18:19:45.026+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:45.026+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:45.026+0900 I/APAMS   (24956): Device RSSI: -74
06-06 18:19:45.036+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-74&phoneid=1
06-06 18:19:45.126+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:45.126+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:45.126+0900 I/APAMS   (24956): Device RSSI: -83
06-06 18:19:45.136+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-83&phoneid=1
06-06 18:19:45.176+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:45.176+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:45.176+0900 I/APAMS   (24956): Device RSSI: -50
06-06 18:19:45.176+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-50&phoneid=1
06-06 18:19:45.286+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:45.286+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:45.286+0900 I/APAMS   (24956): Device RSSI: -71
06-06 18:19:45.286+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-71&phoneid=1
06-06 18:19:45.406+0900 I/APAMS   (24956): <In the CS of the BLE Thread
06-06 18:19:45.406+0900 E/APAMS   (24956): BLE Thread is running... (For 21 sec)
06-06 18:19:45.656+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:45.656+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:45.656+0900 I/APAMS   (24956): Device RSSI: -80
06-06 18:19:45.666+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-80&phoneid=1
06-06 18:19:45.846+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:45.846+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:45.846+0900 I/APAMS   (24956): Device RSSI: -52
06-06 18:19:45.856+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-52&phoneid=1
06-06 18:19:45.956+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:45.956+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:45.956+0900 I/APAMS   (24956): Device RSSI: -81
06-06 18:19:45.956+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-81&phoneid=1
06-06 18:19:46.056+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:46.056+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:46.056+0900 I/APAMS   (24956): Device RSSI: -96
06-06 18:19:46.056+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-96&phoneid=1
06-06 18:19:46.156+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:46.156+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:46.156+0900 I/APAMS   (24956): Device RSSI: -62
06-06 18:19:46.166+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-62&phoneid=1
06-06 18:19:46.286+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:46.286+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:46.286+0900 I/APAMS   (24956): Device RSSI: -78
06-06 18:19:46.296+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-78&phoneid=1
06-06 18:19:46.346+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:46.346+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:46.346+0900 I/APAMS   (24956): Device RSSI: -62
06-06 18:19:46.346+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-62&phoneid=1
06-06 18:19:46.406+0900 I/APAMS   (24956): <In the CS of the BLE Thread
06-06 18:19:46.416+0900 E/APAMS   (24956): BLE Thread is running... (For 22 sec)
06-06 18:19:46.596+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:46.616+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:46.616+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:46.616+0900 I/APAMS   (24956): Device RSSI: -46
06-06 18:19:46.616+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-46&phoneid=1
06-06 18:19:46.716+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:46.716+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:46.716+0900 I/APAMS   (24956): Device RSSI: -93
06-06 18:19:46.716+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-93&phoneid=1
06-06 18:19:46.866+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:46.866+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:46.866+0900 I/APAMS   (24956): Device RSSI: -43
06-06 18:19:46.866+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-43&phoneid=1
06-06 18:19:46.896+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:46.986+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:46.986+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:46.986+0900 I/APAMS   (24956): Device RSSI: -80
06-06 18:19:46.996+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-80&phoneid=1
06-06 18:19:47.066+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:47.066+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:47.066+0900 I/APAMS   (24956): Device RSSI: -97
06-06 18:19:47.076+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-97&phoneid=1
06-06 18:19:47.126+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:47.126+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:47.126+0900 I/APAMS   (24956): Device RSSI: -79
06-06 18:19:47.136+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-79&phoneid=1
06-06 18:19:47.186+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:47.186+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:47.186+0900 I/APAMS   (24956): Device RSSI: -45
06-06 18:19:47.196+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-45&phoneid=1
06-06 18:19:47.306+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:47.306+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:47.316+0900 I/APAMS   (24956): Device RSSI: -76
06-06 18:19:47.316+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-76&phoneid=1
06-06 18:19:47.366+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:47.366+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:47.366+0900 I/APAMS   (24956): Device RSSI: -62
06-06 18:19:47.376+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-62&phoneid=1
06-06 18:19:47.426+0900 I/APAMS   (24956): <In the CS of the BLE Thread
06-06 18:19:47.426+0900 E/APAMS   (24956): BLE Thread is running... (For 23 sec)
06-06 18:19:47.696+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:47.696+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:47.696+0900 I/APAMS   (24956): Device RSSI: -83
06-06 18:19:47.706+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-83&phoneid=1
06-06 18:19:47.876+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:47.876+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:47.876+0900 I/APAMS   (24956): Device RSSI: -51
06-06 18:19:47.886+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-51&phoneid=1
06-06 18:19:47.966+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:47.966+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:47.966+0900 I/APAMS   (24956): Device RSSI: -73
06-06 18:19:47.966+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-73&phoneid=1
06-06 18:19:48.026+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:48.026+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:48.026+0900 I/APAMS   (24956): Device RSSI: -80
06-06 18:19:48.026+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-80&phoneid=1
06-06 18:19:48.186+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:48.186+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:48.186+0900 I/APAMS   (24956): Device RSSI: -42
06-06 18:19:48.196+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-42&phoneid=1
06-06 18:19:48.256+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:48.256+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:48.256+0900 I/APAMS   (24956): Device RSSI: -80
06-06 18:19:48.256+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-80&phoneid=1
06-06 18:19:48.426+0900 I/APAMS   (24956): <In the CS of the BLE Thread
06-06 18:19:48.426+0900 E/APAMS   (24956): BLE Thread is running... (For 24 sec)
06-06 18:19:48.716+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:48.716+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:48.716+0900 I/APAMS   (24956): Device RSSI: -78
06-06 18:19:48.716+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-78&phoneid=1
06-06 18:19:48.906+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:48.906+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:48.906+0900 I/APAMS   (24956): Device RSSI: -42
06-06 18:19:48.906+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-42&phoneid=1
06-06 18:19:52.206+0900 E/EFL     (24956): elementary<24956> elm_layout.c:1469 elm_layout_file_set() failed to set edje file '/opt/usr/apps/org.tizen.helloworld/res/ui_controls.edj', group 'popup_image_list_layout': No Error
06-06 18:19:52.216+0900 E/EFL     (24956): elementary<24956> elm_layout.c:833 _elm_layout_smart_content_set() could not swallow 0xb8ca7ef8 into part 'elm.swallow.content'
06-06 18:19:52.266+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:52.266+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:52.266+0900 I/APAMS   (24956): Device RSSI: -80
06-06 18:19:52.266+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-80&phoneid=1
06-06 18:19:52.316+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:52.316+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:52.316+0900 I/APAMS   (24956): Device RSSI: -80
06-06 18:19:52.316+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-80&phoneid=1
06-06 18:19:52.426+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:52.426+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:52.426+0900 I/APAMS   (24956): Device RSSI: -85
06-06 18:19:52.426+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-85&phoneid=1
06-06 18:19:52.476+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:52.476+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:52.476+0900 I/APAMS   (24956): Device RSSI: -62
06-06 18:19:52.476+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-62&phoneid=1
06-06 18:19:52.566+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:52.566+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:52.566+0900 I/APAMS   (24956): Device RSSI: -80
06-06 18:19:52.576+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-80&phoneid=1
06-06 18:19:52.616+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:52.616+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:52.616+0900 I/APAMS   (24956): Device RSSI: -72
06-06 18:19:52.626+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-72&phoneid=1
06-06 18:19:52.676+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:52.676+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:52.676+0900 I/APAMS   (24956): Device RSSI: -84
06-06 18:19:52.686+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-84&phoneid=1
06-06 18:19:52.806+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:52.806+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:52.806+0900 I/APAMS   (24956): Device RSSI: -53
06-06 18:19:52.816+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-53&phoneid=1
06-06 18:19:52.856+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:52.856+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:52.856+0900 I/APAMS   (24956): Device RSSI: -77
06-06 18:19:52.866+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-77&phoneid=1
06-06 18:19:52.916+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:52.916+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:52.916+0900 I/APAMS   (24956): Device RSSI: -72
06-06 18:19:52.926+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-72&phoneid=1
06-06 18:19:52.986+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:52.986+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:52.986+0900 I/APAMS   (24956): Device RSSI: -55
06-06 18:19:52.986+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-55&phoneid=1
06-06 18:19:53.046+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:53.046+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:53.046+0900 I/APAMS   (24956): Device RSSI: -77
06-06 18:19:53.046+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-77&phoneid=1
06-06 18:19:53.106+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:53.106+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:53.106+0900 I/APAMS   (24956): Device RSSI: -87
06-06 18:19:53.106+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-87&phoneid=1
06-06 18:19:53.226+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:53.226+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:53.226+0900 I/APAMS   (24956): Device RSSI: -78
06-06 18:19:53.226+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-78&phoneid=1
06-06 18:19:53.326+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:53.326+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:53.326+0900 I/APAMS   (24956): Device RSSI: -61
06-06 18:19:53.326+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-61&phoneid=1
06-06 18:19:53.406+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:53.406+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:53.406+0900 I/APAMS   (24956): Device RSSI: -83
06-06 18:19:53.416+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-83&phoneid=1
06-06 18:19:53.456+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:53.456+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:53.456+0900 I/APAMS   (24956): Device RSSI: -79
06-06 18:19:53.456+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-79&phoneid=1
06-06 18:19:53.586+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:53.586+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:53.586+0900 I/APAMS   (24956): Device RSSI: -74
06-06 18:19:53.596+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-74&phoneid=1
06-06 18:19:53.636+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:53.636+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:53.636+0900 I/APAMS   (24956): Device RSSI: -53
06-06 18:19:53.636+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-53&phoneid=1
06-06 18:19:53.676+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:53.676+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:53.676+0900 I/APAMS   (24956): Device RSSI: -87
06-06 18:19:53.686+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-87&phoneid=1
06-06 18:19:53.726+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:53.726+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:53.726+0900 I/APAMS   (24956): Device RSSI: -90
06-06 18:19:53.736+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-90&phoneid=1
06-06 18:19:53.826+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:53.826+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:53.826+0900 I/APAMS   (24956): Device RSSI: -80
06-06 18:19:53.836+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-80&phoneid=1
06-06 18:19:53.876+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:53.876+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:53.876+0900 I/APAMS   (24956): Device RSSI: -56
06-06 18:19:53.876+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-56&phoneid=1
06-06 18:19:53.926+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:53.926+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:53.926+0900 I/APAMS   (24956): Device RSSI: -77
06-06 18:19:53.926+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-77&phoneid=1
06-06 18:19:53.966+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:53.966+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:53.966+0900 I/APAMS   (24956): Device RSSI: -81
06-06 18:19:53.976+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-81&phoneid=1
06-06 18:19:54.026+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:54.026+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:54.026+0900 I/APAMS   (24956): Device RSSI: -76
06-06 18:19:54.036+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-76&phoneid=1
06-06 18:19:54.086+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:54.086+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:54.086+0900 I/APAMS   (24956): Device RSSI: -47
06-06 18:19:54.086+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-47&phoneid=1
06-06 18:19:54.186+0900 I/APAMS   (24956): <In the CS of the BLE Thread
06-06 18:19:54.196+0900 E/APAMS   (24956): BLE Thread is running... (For 25 sec)
06-06 18:19:54.216+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:54.216+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:54.216+0900 I/APAMS   (24956): Device RSSI: -65
06-06 18:19:54.246+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-65&phoneid=1
06-06 18:19:54.326+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:54.326+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:54.326+0900 I/APAMS   (24956): Device RSSI: -66
06-06 18:19:54.336+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-66&phoneid=1
06-06 18:19:54.426+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:54.426+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:54.426+0900 I/APAMS   (24956): Device RSSI: -67
06-06 18:19:54.426+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-67&phoneid=1
06-06 18:19:54.516+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:54.516+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:54.516+0900 I/APAMS   (24956): Device RSSI: -73
06-06 18:19:54.536+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-73&phoneid=1
06-06 18:19:54.576+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:54.576+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:54.576+0900 I/APAMS   (24956): Device RSSI: -41
06-06 18:19:54.586+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-41&phoneid=1
06-06 18:19:54.626+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:54.626+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:54.626+0900 I/APAMS   (24956): Device RSSI: -67
06-06 18:19:54.636+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-67&phoneid=1
06-06 18:19:54.696+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:54.696+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:54.696+0900 I/APAMS   (24956): Device RSSI: -76
06-06 18:19:54.696+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-76&phoneid=1
06-06 18:19:54.746+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:54.746+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:54.746+0900 I/APAMS   (24956): Device RSSI: -47
06-06 18:19:54.756+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-47&phoneid=1
06-06 18:19:54.846+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:54.846+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:54.846+0900 I/APAMS   (24956): Device RSSI: -85
06-06 18:19:54.856+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-85&phoneid=1
06-06 18:19:54.896+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:54.896+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:54.896+0900 I/APAMS   (24956): Device RSSI: -79
06-06 18:19:54.896+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-79&phoneid=1
06-06 18:19:54.936+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:54.936+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:54.936+0900 I/APAMS   (24956): Device RSSI: -69
06-06 18:19:54.946+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-69&phoneid=1
06-06 18:19:55.016+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:55.016+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:55.016+0900 I/APAMS   (24956): Device RSSI: -40
06-06 18:19:55.016+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-40&phoneid=1
06-06 18:19:55.056+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:55.056+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:55.056+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:55.056+0900 I/APAMS   (24956): Device RSSI: -75
06-06 18:19:55.066+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-75&phoneid=1
06-06 18:19:55.106+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:55.106+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:55.106+0900 I/APAMS   (24956): Device RSSI: -41
06-06 18:19:55.116+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:55.116+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-41&phoneid=1
06-06 18:19:55.176+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:55.206+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:55.206+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:55.206+0900 I/APAMS   (24956): Device RSSI: -79
06-06 18:19:55.216+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-79&phoneid=1
06-06 18:19:55.236+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:55.256+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:55.256+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:55.256+0900 I/APAMS   (24956): Device RSSI: -79
06-06 18:19:55.276+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-79&phoneid=1
06-06 18:19:55.366+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:55.366+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:55.366+0900 I/APAMS   (24956): Device RSSI: -71
06-06 18:19:55.366+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-71&phoneid=1
06-06 18:19:55.446+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:55.446+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:55.446+0900 I/APAMS   (24956): Device RSSI: -73
06-06 18:19:55.456+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-73&phoneid=1
06-06 18:19:55.496+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:55.496+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:55.496+0900 I/APAMS   (24956): Device RSSI: -71
06-06 18:19:55.516+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-71&phoneid=1
06-06 18:19:55.596+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:55.606+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:55.606+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:55.606+0900 I/APAMS   (24956): Device RSSI: -48
06-06 18:19:55.606+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-48&phoneid=1
06-06 18:19:55.646+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:55.646+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:55.646+0900 I/APAMS   (24956): Device RSSI: -69
06-06 18:19:55.656+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:55.656+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-69&phoneid=1
06-06 18:19:55.756+0900 I/APAMS   (24956): <In the CS of the BLE Thread
06-06 18:19:55.766+0900 E/APAMS   (24956): BLE Thread is running... (For 26 sec)
06-06 18:19:55.806+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:55.806+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:55.806+0900 I/APAMS   (24956): Device RSSI: -38
06-06 18:19:55.816+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-38&phoneid=1
06-06 18:19:55.836+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:55.896+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:55.906+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:55.906+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:55.906+0900 I/APAMS   (24956): Device RSSI: -55
06-06 18:19:55.916+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-55&phoneid=1
06-06 18:19:55.986+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:55.986+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:55.986+0900 I/APAMS   (24956): Device RSSI: -66
06-06 18:19:55.996+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-66&phoneid=1
06-06 18:19:56.016+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:56.046+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:56.046+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:56.046+0900 I/APAMS   (24956): Device RSSI: -68
06-06 18:19:56.056+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-68&phoneid=1
06-06 18:19:56.076+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:56.136+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:56.146+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:56.146+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:56.146+0900 I/APAMS   (24956): Device RSSI: -61
06-06 18:19:56.146+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-61&phoneid=1
06-06 18:19:56.226+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:56.226+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:56.226+0900 I/APAMS   (24956): Device RSSI: -75
06-06 18:19:56.236+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-75&phoneid=1
06-06 18:19:56.276+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:56.276+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:56.276+0900 I/APAMS   (24956): Device RSSI: -39
06-06 18:19:56.286+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-39&phoneid=1
06-06 18:19:56.316+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:56.376+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:56.376+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:56.376+0900 I/APAMS   (24956): Device RSSI: -66
06-06 18:19:56.386+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-66&phoneid=1
06-06 18:19:56.486+0900 E/EFL     (24956): elementary<24956> elm_layout.c:1469 elm_layout_file_set() failed to set edje file '/opt/usr/apps/org.tizen.helloworld/res/ui_controls.edj', group 'popup_image_list_layout': No Error
06-06 18:19:56.486+0900 E/EFL     (24956): elementary<24956> elm_layout.c:833 _elm_layout_smart_content_set() could not swallow 0xb8c7e788 into part 'elm.swallow.content'
06-06 18:19:56.526+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:56.526+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:56.536+0900 I/APAMS   (24956): Device RSSI: -70
06-06 18:19:56.536+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-70&phoneid=1
06-06 18:19:56.626+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:56.626+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:56.626+0900 I/APAMS   (24956): Device RSSI: -48
06-06 18:19:56.626+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-48&phoneid=1
06-06 18:19:56.776+0900 I/APAMS   (24956): <In the CS of the BLE Thread
06-06 18:19:56.776+0900 E/APAMS   (24956): BLE Thread is running... (For 27 sec)
06-06 18:19:56.806+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:56.806+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:56.816+0900 I/APAMS   (24956): Device RSSI: -68
06-06 18:19:56.816+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-68&phoneid=1
06-06 18:19:56.946+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:56.946+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:56.946+0900 I/APAMS   (24956): Device RSSI: -69
06-06 18:19:56.946+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-69&phoneid=1
06-06 18:19:57.046+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:57.046+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:57.046+0900 I/APAMS   (24956): Device RSSI: -54
06-06 18:19:57.046+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-54&phoneid=1
06-06 18:19:57.156+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:57.156+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:57.156+0900 I/APAMS   (24956): Device RSSI: -69
06-06 18:19:57.166+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-69&phoneid=1
06-06 18:19:57.216+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:57.246+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:57.246+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:57.246+0900 I/APAMS   (24956): Device RSSI: -71
06-06 18:19:57.256+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-71&phoneid=1
06-06 18:19:57.276+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:57.296+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:57.296+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:57.296+0900 I/APAMS   (24956): Device RSSI: -62
06-06 18:19:57.296+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-62&phoneid=1
06-06 18:19:57.426+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:57.426+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:57.426+0900 I/APAMS   (24956): Device RSSI: -39
06-06 18:19:57.436+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-39&phoneid=1
06-06 18:19:57.456+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:57.546+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:57.546+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:57.546+0900 I/APAMS   (24956): Device RSSI: -39
06-06 18:19:57.556+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-39&phoneid=1
06-06 18:19:57.776+0900 I/APAMS   (24956): <In the CS of the BLE Thread
06-06 18:19:57.776+0900 E/APAMS   (24956): BLE Thread is running... (For 28 sec)
06-06 18:19:57.836+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:57.836+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:57.836+0900 I/APAMS   (24956): Device RSSI: -71
06-06 18:19:57.836+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-71&phoneid=1
06-06 18:19:57.916+0900 E/EFL     (24956): elementary<24956> elm_layout.c:1469 elm_layout_file_set() failed to set edje file '/opt/usr/apps/org.tizen.helloworld/res/ui_controls.edj', group 'popup_image_list_layout': No Error
06-06 18:19:57.926+0900 E/EFL     (24956): elementary<24956> elm_layout.c:833 _elm_layout_smart_content_set() could not swallow 0xb8ca5840 into part 'elm.swallow.content'
06-06 18:19:57.936+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:57.986+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:57.986+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:57.986+0900 I/APAMS   (24956): Device RSSI: -64
06-06 18:19:57.996+0900 W/CAM_APP (17993): cam_sensor_control.c: cam_sensor_rotation_change(166) > [33mignore rotation callback[0m
06-06 18:19:57.996+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-64&phoneid=1
06-06 18:19:58.066+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:58.066+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:58.066+0900 I/APAMS   (24956): Device RSSI: -69
06-06 18:19:58.066+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-69&phoneid=1
06-06 18:19:58.176+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:58.176+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:58.176+0900 I/APAMS   (24956): Device RSSI: -68
06-06 18:19:58.176+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-68&phoneid=1
06-06 18:19:58.286+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:58.286+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:58.286+0900 I/APAMS   (24956): Device RSSI: -89
06-06 18:19:58.296+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-89&phoneid=1
06-06 18:19:58.416+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:58.416+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:58.416+0900 I/APAMS   (24956): Device RSSI: -61
06-06 18:19:58.416+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-61&phoneid=1
06-06 18:19:58.576+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:58.576+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:58.576+0900 I/APAMS   (24956): Device RSSI: -42
06-06 18:19:58.576+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-42&phoneid=1
06-06 18:19:58.776+0900 I/APAMS   (24956): <In the CS of the BLE Thread
06-06 18:19:58.776+0900 E/APAMS   (24956): BLE Thread is running... (For 29 sec)
06-06 18:19:58.856+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:58.856+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:58.856+0900 I/APAMS   (24956): Device RSSI: -71
06-06 18:19:58.856+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-71&phoneid=1
06-06 18:19:58.976+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:58.976+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:58.976+0900 I/APAMS   (24956): Device RSSI: -61
06-06 18:19:58.976+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-61&phoneid=1
06-06 18:19:59.106+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:59.106+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:4D:9E
06-06 18:19:59.106+0900 I/APAMS   (24956): Device RSSI: -71
06-06 18:19:59.116+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:4D:9E&rssi=-71&phoneid=1
06-06 18:19:59.256+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:59.256+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:59.256+0900 I/APAMS   (24956): Device RSSI: -63
06-06 18:19:59.256+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-63&phoneid=1
06-06 18:19:59.326+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:59.326+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:06:82
06-06 18:19:59.326+0900 I/APAMS   (24956): Device RSSI: -68
06-06 18:19:59.326+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:06:82&rssi=-68&phoneid=1
06-06 18:19:59.436+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:59.436+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:59.436+0900 I/APAMS   (24956): Device RSSI: -44
06-06 18:19:59.446+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-44&phoneid=1
06-06 18:19:59.526+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:59.526+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:39:58
06-06 18:19:59.526+0900 I/APAMS   (24956): Device RSSI: -78
06-06 18:19:59.536+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:39:58&rssi=-78&phoneid=1
06-06 18:19:59.616+0900 I/APAMS   (24956): BT_ADAPTER_DEVICE_DISCOVERY_FOUND
06-06 18:19:59.616+0900 I/APAMS   (24956): Device Address: 78:A5:04:4F:3A:DC
06-06 18:19:59.616+0900 I/APAMS   (24956): Device RSSI: -62
06-06 18:19:59.626+0900 I/APAMS   (24956): howd?  trash=asd&functionid=1&beaconid=78:A5:04:4F:3A:DC&rssi=-62&phoneid=1
06-06 18:19:59.866+0900 W/AUL_AMD (  445): amd_key.c: _key_ungrab(250) > fail(-1) to ungrab key(XF86Stop)
06-06 18:19:59.866+0900 W/AUL_AMD (  445): amd_launch.c: __e17_status_handler(2132) > back key ungrab error
06-06 18:19:59.876+0900 I/AUL_PAD (  461): sigchild.h: __launchpad_sig_child(142) > dead_pid = 24956 pgid = 24956
06-06 18:19:59.876+0900 I/AUL_PAD (  461): sigchild.h: __sigchild_action(123) > dead_pid(24956)
06-06 18:19:59.876+0900 I/AUL_PAD (  461): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
06-06 18:19:59.876+0900 I/AUL_PAD (  461): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
06-06 18:19:59.926+0900 W/PROCESSMGR(  344): e_mod_processmgr.c: _e_mod_processmgr_send_mDNIe_action(577) > [PROCESSMGR] =====================> Broadcast mDNIeStatus : PID=587
06-06 18:19:59.936+0900 I/Tizen::System( 1147): (246) > Terminated app [org.tizen.helloworld]
06-06 18:19:59.936+0900 I/Tizen::Io( 1147): (729) > Entry not found
06-06 18:19:59.936+0900 I/Tizen::App( 1048): (243) > App[org.tizen.helloworld] pid[24956] terminate event is forwarded
06-06 18:19:59.936+0900 I/Tizen::System( 1048): (256) > osp.accessorymanager.service provider is found.
06-06 18:19:59.936+0900 I/Tizen::System( 1048): (196) > Accessory Owner is removed [org.tizen.helloworld, 24956, ]
06-06 18:19:59.936+0900 I/Tizen::System( 1048): (256) > osp.system.service provider is found.
06-06 18:19:59.936+0900 I/Tizen::App( 1048): (506) > TerminatedApp(org.tizen.helloworld)
06-06 18:19:59.936+0900 I/Tizen::App( 1048): (512) > Not registered pid(24956)
06-06 18:19:59.936+0900 I/Tizen::App( 1048): (782) > Finished invoking application event listener for org.tizen.helloworld, 24956.
06-06 18:19:59.946+0900 I/AUL_AMD (  445): amd_main.c: __app_dead_handler(256) > __app_dead_handler, pid: 24956
06-06 18:19:59.956+0900 I/CAPI_APPFW_APPLICATION(  587): app_main.c: app_appcore_resume(223) > app_appcore_resume
06-06 18:19:59.956+0900 E/cluster-home(  587): homescreen-main.cpp: app_resume(422) >  app resume
06-06 18:19:59.986+0900 I/Tizen::System( 1147): (157) > change brightness system value.
06-06 18:19:59.986+0900 I/Tizen::App( 1147): (782) > Finished invoking application event listener for org.tizen.helloworld, 24956.
06-06 18:20:00.026+0900 I/Tizen::System( 1147): (259) > Active app [com.samsun], current [org.tizen.] 
06-06 18:20:00.026+0900 I/Tizen::Io( 1147): (729) > Entry not found
06-06 18:20:00.056+0900 W/CRASH_MANAGER(25113): worker.c: worker_job(1198) > 062495668656c143358239
