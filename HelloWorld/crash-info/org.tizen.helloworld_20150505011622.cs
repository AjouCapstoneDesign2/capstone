S/W Version Information
Model: Mobile-Emulator
Tizen-Version: 2.3.0
Build-Number: Tizen-2.3.0_Mobile-Emulator_20141226.1803
Build-Date: 2014.12.26 18:03:32

Crash Information
Process Name: helloworld
PID: 10521
Date: 2015-05-05 01:16:22+0900
Executable File Path: /opt/usr/apps/org.tizen.helloworld/bin/helloworld
Signal: 11
      (SIGSEGV)
      si_code: 1
      address not mapped to object
      si_addr = 0x8

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000000, esi = 0xb83a4a38
ebp = 0xbfbf29c8, esp = 0xbfbf2970
eax = 0x00000000, ebx = 0xb4fa16b0
ecx = 0xb8422b18, edx = 0xb8453c40
eip = 0xb4f9fc14

Memory Information
MemTotal:      124 KB
MemFree:        48 KB
Buffers:         7 KB
Cached:     151676 KB
VmPeak:      54756 KB
VmSize:      54756 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       15504 KB
VmRSS:       15504 KB
VmData:       5256 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       33116 KB
VmPTE:          60 KB
VmSwap:          0 KB

Maps Information
b4763000 b4764000 r-xp /usr/lib/evas/modules/loaders/eet/linux-gnu-i686-1.7.99/module.so
b4799000 b47bd000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b48b4000 b48b7000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b48b8000 b48d1000 r-xp /usr/lib/yagl/libEGL.so.1.0
b48d2000 b491a000 r-xp /usr/lib/yagl/libGLESv2.so.2.0
b491d000 b4986000 r-xp /usr/lib/evas/modules/engines/gl_x11/linux-gnu-i686-1.7.99/module.so
b4b8c000 b4b8f000 r-xp /usr/lib/libdri2.so.0.0.0
b4b90000 b4b99000 r-xp /usr/lib/libtbm.so.1.0.0
b4b9a000 b4ba5000 r-xp /usr/lib/libdrm.so.2.4.0
b4ba6000 b4bac000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b4bad000 b4bb6000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b4bb7000 b4bc0000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b4bc1000 b4bc9000 r-xp /usr/lib/libxcb-render.so.0.0.0
b4bca000 b4bcc000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4bcd000 b4bf4000 r-xp /usr/lib/libpng12.so.0.50.0
b4bf5000 b4bfb000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b4bfc000 b4c00000 r-xp /usr/lib/libnative-buffer.so.0.1.0
b4c01000 b4c06000 r-xp /usr/lib/libcapi-media-image-util.so.0.3.23
b4c07000 b4d2a000 r-xp /usr/lib/libcairo.so.2.11200.14
b4d2d000 b4d4a000 r-xp /usr/lib/libtts.so
b4d4b000 b4d6d000 r-xp /usr/lib/libefl-assist.so.0.1.0
b4d6e000 b4d71000 r-xp /usr/lib/libefl-extension.so.0.1.0
b4d74000 b4d81000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b4d82000 b4d8d000 r-xp /lib/libnss_files-2.13.so
b4d8f000 b4eb1000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b4ec1000 b4ef7000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b4ef9000 b4f11000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b4f12000 b4f1d000 r-xp /usr/lib/libminizip.so.1.0.0
b4f1e000 b4f40000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4f41000 b4f43000 r-xp /usr/lib/libpkgmgr_installer_status_broadcast_server.so.0.1.0
b4f44000 b4f4b000 r-xp /usr/lib/libpkgmgr_installer_client.so.0.1.0
b4f4c000 b4f64000 r-xp /usr/lib/libpkgmgr-client.so.0.1.68
b4f65000 b4f6d000 r-xp /usr/lib/libcapi-appfw-package-manager.so.0.0.49
b4f6e000 b4f76000 r-xp /usr/lib/libcapi-appfw-app-manager.so.0.2.4
b4f77000 b4f7a000 r-xp /usr/lib/libiniparser.so.0
b4f7c000 b4f87000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b4f88000 b4f91000 r-xp /usr/lib/libappsvc.so.0.1.0
b4f93000 b4f9e000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b4f9f000 b4fa1000 r-xp /opt/usr/apps/org.tizen.helloworld/bin/helloworld
b4fa2000 b4fa8000 r-xp /usr/lib/libogg.so.0.7.1
b4fa9000 b4fd4000 r-xp /usr/lib/libvorbis.so.0.4.3
b4fd5000 b50c0000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b50ce000 b511a000 r-xp /usr/lib/libFLAC.so.8.2.0
b511b000 b511d000 r-xp /usr/lib/libXau.so.6.0.0
b511e000 b512e000 r-xp /usr/lib/libspdy.so.0.0.0
b512f000 b518e000 r-xp /usr/lib/libssl.so.1.0.0
b5193000 b51c4000 r-xp /usr/lib/libidn.so.11.5.44
b51c5000 b51d5000 r-xp /usr/lib/libcares.so.2.1.0
b51d6000 b5200000 r-xp /usr/lib/libexif.so.12.3.3
b520c000 b5279000 r-xp /usr/lib/libsndfile.so.1.0.25
b527f000 b52a5000 r-xp /lib/libexpat.so.1.5.2
b52a7000 b52ed000 r-xp /usr/lib/libicule.so.51.1
b52ef000 b530f000 r-xp /usr/lib/libxcb.so.1.1.0
b5310000 b5374000 r-xp /usr/lib/libcurl.so.4.3.0
b5376000 b5382000 r-xp /usr/lib/libethumb.so.1.7.99
b5e20000 b5ef8000 r-xp /usr/lib/libstdc++.so.6.0.16
b5f04000 b5f07000 r-xp /usr/lib/libctxdata.so.0.0.0
b5f08000 b5f1e000 r-xp /usr/lib/libremix.so.0.0.0
b5f1f000 b5f21000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5f22000 b5f4e000 r-xp /usr/lib/liblua-5.1.so
b5f4f000 b5f59000 r-xp /usr/lib/libembryo.so.1.7.99
b5f5a000 b5fa0000 r-xp /usr/lib/libjpeg.so.8.0.2
b5fb1000 b6033000 r-xp /usr/lib/libpixman-1.so.0.28.2
b6038000 b606c000 r-xp /usr/lib/libfontconfig.so.1.5.0
b606e000 b60da000 r-xp /usr/lib/libharfbuzz.so.0.907.0
b60db000 b60f1000 r-xp /usr/lib/libfribidi.so.0.3.1
b60f2000 b6175000 r-xp /usr/lib/libfreetype.so.6.8.1
b6179000 b617c000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b617d000 b6183000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6184000 b618a000 r-xp /usr/lib/libecore_fb.so.1.7.99
b618c000 b619d000 r-xp /usr/lib/libXext.so.6.4.0
b619e000 b62d2000 r-xp /usr/lib/libX11.so.6.3.0
b62d6000 b62db000 r-xp /usr/lib/libXtst.so.6.1.0
b62dc000 b62e4000 r-xp /usr/lib/libXrender.so.1.3.0
b62e5000 b62ee000 r-xp /usr/lib/libXrandr.so.2.2.0
b62ef000 b62f1000 r-xp /usr/lib/libXinerama.so.1.0.0
b62f2000 b6300000 r-xp /usr/lib/libXi.so.6.1.0
b6301000 b6305000 r-xp /usr/lib/libXfixes.so.3.1.0
b6306000 b6308000 r-xp /usr/lib/libXgesture.so.7.0.0
b6309000 b630b000 r-xp /usr/lib/libXcomposite.so.1.0.0
b630c000 b630e000 r-xp /usr/lib/libXdamage.so.1.1.0
b630f000 b6318000 r-xp /usr/lib/libXcursor.so.1.0.2
b6319000 b6344000 r-xp /usr/lib/libecore_con.so.1.7.99
b6346000 b634e000 r-xp /usr/lib/libecore_imf.so.1.7.99
b634f000 b635a000 r-xp /usr/lib/libethumb_client.so.1.7.99
b635b000 b6361000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6362000 b6383000 r-xp /usr/lib/libefreet.so.1.7.99
b6385000 b6391000 r-xp /usr/lib/libedbus.so.1.7.99
b6392000 b64f1000 r-xp /usr/lib/libicuuc.so.51.1
b64ff000 b6708000 r-xp /usr/lib/libicui18n.so.51.1
b6711000 b67ad000 r-xp /usr/lib/libedje.so.1.7.99
b67af000 b67c0000 r-xp /usr/lib/libecore_input.so.1.7.99
b67c1000 b67c8000 r-xp /usr/lib/libecore_file.so.1.7.99
b67c9000 b67ef000 r-xp /usr/lib/libeet.so.1.7.99
b67f8000 b6922000 r-xp /usr/lib/libevas.so.1.7.99
b693f000 b6973000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6975000 b69b9000 r-xp /usr/lib/libecore_x.so.1.7.99
b69bb000 b6bb4000 r-xp /usr/lib/libelementary.so.1.7.99
b6bc3000 b6bc6000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b6bc7000 b6bcd000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6bce000 b6bd2000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6bd6000 b6bd7000 r-xp /usr/lib/libjournal.so.0.1.0
b6bd8000 b6d20000 r-xp /usr/lib/libxml2.so.2.7.8
b6d27000 b6d3a000 r-xp /lib/libresolv-2.13.so
b6d3e000 b6d5b000 r-xp /lib/libz.so.1.2.5
b6d5c000 b6d5f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d60000 b6d65000 r-xp /usr/lib/libffi.so.5.0.10
b6d66000 b6d67000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6d69000 b6d6d000 r-xp /lib/libattr.so.1.1.0
b6d6e000 b6f7f000 r-xp /usr/lib/libcrypto.so.1.0.0
b6f9a000 b6fbd000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6fbe000 b6fe6000 r-xp /lib/libm-2.13.so
b6fe8000 b7043000 r-xp /usr/lib/libeina.so.1.7.99
b7046000 b7050000 r-xp /usr/lib/libvconf.so.0.2.45
b7051000 b7054000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b7055000 b70a3000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b70a4000 b7205000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b7209000 b7210000 r-xp /lib/librt-2.13.so
b7213000 b7218000 r-xp /usr/lib/libcapi-base-common.so.0.1.6
b7219000 b7233000 r-xp /lib/libgcc_s-4.6.4.so.1
b7234000 b723c000 r-xp /lib/libcrypt-2.13.so
b7265000 b7269000 r-xp /lib/libcap.so.2.21
b726a000 b726c000 r-xp /usr/lib/libiri.so
b726e000 b7299000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b729a000 b72ba000 r-xp /usr/lib/libecore.so.1.7.99
b72c9000 b72d2000 r-xp /usr/lib/libxdgmime.so.1.1.0
b72d3000 b73f6000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b73f7000 b740a000 r-xp /usr/lib/libail.so.0.1.0
b740c000 b7431000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b7432000 b743c000 r-xp /lib/libunwind.so.8.0.1
b7446000 b75b7000 r-xp /lib/libc-2.13.so
b75bd000 b7607000 r-xp /usr/lib/libdbus-1.so.3.7.2
b7608000 b760d000 r-xp /usr/lib/libbundle.so.0.1.22
b760e000 b7611000 r-xp /lib/libdl-2.13.so
b7614000 b7619000 r-xp /usr/lib/libsmack.so.1.0.0
b761a000 b76c2000 r-xp /usr/lib/libsqlite3.so.0.8.6
b76c5000 b76df000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76e0000 b76f7000 r-xp /lib/libpthread-2.13.so
b76fb000 b76fe000 r-xp /usr/lib/libdlog.so.0.0.0
b76ff000 b770f000 r-xp /usr/lib/libaul.so.0.1.0
b7713000 b7719000 r-xp /usr/lib/libappcore-common.so.1.1
b771a000 b771f000 r-xp /usr/lib/libappcore-efl.so.1.1
b7721000 b7726000 r-xp /usr/lib/libsys-assert.so
b7729000 b7747000 r-xp /lib/ld-2.13.so
b7747000 b7748000 r-xp [vdso]
b774a000 b7751000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:10521)
Call Stack Count: 17
 0: btn_clicked_cb + 0x14 (0xb4f9fc14) [/opt/usr/apps/org.tizen.helloworld/bin/helloworld] + 0xc14
 1: (0xb6a25986) [/usr/lib/libelementary.so.1] + 0x6a986
 2: (0xb677a800) [/usr/lib/libedje.so.1] + 0x69800
 3: (0xb6781b92) [/usr/lib/libedje.so.1] + 0x70b92
 4: (0xb677b8dc) [/usr/lib/libedje.so.1] + 0x6a8dc
 5: (0xb677be0f) [/usr/lib/libedje.so.1] + 0x6ae0f
 6: (0xb677bfc4) [/usr/lib/libedje.so.1] + 0x6afc4
 7: (0xb72a6c22) [/usr/lib/libecore.so.1] + 0xcc22
 8: (0xb72a3269) [/usr/lib/libecore.so.1] + 0x9269
 9: (0xb72a816a) [/usr/lib/libecore.so.1] + 0xe16a
10: ecore_main_loop_begin + 0x3f (0xb72a86bf) [/usr/lib/libecore.so.1] + 0xe6bf
11: elm_run + 0x17 (0xb6ac2a27) [/usr/lib/libelementary.so.1] + 0x107a27
12: appcore_efl_main + 0x3d2 (0xb771ce32) [/usr/lib/libappcore-efl.so.1] + 0x2e32
13: ui_app_main + 0x130 (0xb6bd0500) [/usr/lib/libcapi-appfw-application.so.0] + 0x2500
14: main + 0x19f (0xb4f9fe1f) [/opt/usr/apps/org.tizen.helloworld/bin/helloworld] + 0xe1f
15: ((nil)) (null)
16: ((nil)) (null)
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
05-05 01:16:16.351+0900 D/rpm-installer(10469): MIIDeTCCAmGgAwIBAgIBZTANBgkqhkiG9w0BAQsFADCBnjELMAkGA1UEBhMCS1IxFDASBgNVBAgM
05-05 01:16:16.351+0900 D/rpm-installer(10469): C1NvdXRoIEtvcmVhMQ4wDAYDVQQHDAVTdXdvbjEmMCQGA1UECgwdU2Ftc3VuZyBFbGVjdHJvbmlj
05-05 01:16:16.351+0900 D/rpm-installer(10469): cyBDby4sIEx0ZC4xDzANBgNVBAsMBk1vYmlsZTEwMC4GA1UEAwwnU2Ftc3VuZyBUaXplbiBERVZF
05-05 01:16:16.351+0900 D/rpm-installer(10469): TE9QRVIgUHVibGljIENBIENsYXNzMB4XDTE1MDQwMjEwNTUyMVoXDTE2MDQwMTEwNTUyMVowRTEg
05-05 01:16:16.351+0900 D/rpm-installer(10469): MB4GA1UEAwwXU2Ftc3VuZyBUaXplbiBEZXZlbG9wZXIxITAfBgkqhkiG9w0BCQEWEjJod2Fuc3Vu
05-05 01:16:16.351+0900 D/rpm-installer(10469): QG5hdmVyLmNvbTCCASIwDQYJKoZIhvcNAQEBBQADggEPADCCAQoCggEBAOcrHtR9UN/2GAErR7J0
05-05 01:16:16.351+0900 D/rpm-installer(10469): jHkM1uFPe5GV7tfW8yBedpaVLq7VK3RBrBCYqe7Prf6rfRW4PhrFS6XNh/jmHBNO2F4Emwe+QrTz
05-05 01:16:16.351+0900 D/rpm-installer(10469): 7mjKTMHqf3XDKQrCyfQF9ZHk2SVLV+KHPQ3L79j5B+LrIixXZ/lPm6kATjKyhLO7HVCPmIBGVmDM
05-05 01:16:16.351+0900 D/rpm-installer(10469): bWfqbwT5H9cssdVN4VN9ytJmExymb7sVkego2hTz1b3jV6+WY0Osj+VogfctLJd1Crngf1JiLsIP
05-05 01:16:16.351+0900 D/rpm-installer(10469): YWQo6AuF+L/x+ZGjkLxDMOD5HU2uWdqYt7uZcRpg/eThQDvOP+cxh2PZvRdTs8eREJbjBWgaqkLG
05-05 01:16:16.351+0900 D/rpm-installer(10469): h0B/mkY/lJ1Y1mXTbRUCAwEAAaMaMBgwCQYDVR0TBAIwADALBgNVHQ8EBAMCB4AwDQYJKoZIhvcN
05-05 01:16:16.351+0900 D/rpm-installer(10469): AQELBQADggEBAFuFskAA+hz8py4Vr6QbCRzWAXtV7c6fswZBd2DK20GYxFLXxEKxTzO/GHE4O08m
05-05 01:16:16.351+0900 D/rpm-installer(10469): kbpK1sV5
05-05 01:16:16.351+0900 D/rpm-installer(10469): rpm-installer-signature.c: _ri_process_x509certificate(470) > x509certificate, len=[1298]
05-05 01:16:16.351+0900 D/rpm-installer(10469): 
05-05 01:16:16.351+0900 D/rpm-installer(10469): MIIDuzCCAqOgAwIBAgICL+cwDQYJKoZIhvcNAQELBQAwgY8xCzAJBgNVBAYTAktSMRQwEgYDVQQI
05-05 01:16:16.351+0900 D/rpm-installer(10469): DAtTb3V0aCBLb3JlYTEOMAwGA1UEBwwFU3V3b24xJjAkBgNVBAoMHVNhbXN1bmcgRWxlY3Ryb25p
05-05 01:16:16.351+0900 D/rpm-installer(10469): Y3MgQ28uLCBMdGQuMTIwMAYDVQQDDClTYW1zdW5nIFRpemVuIERFVkVMT1BFUiBQdWJsaWMgUm9v
05-05 01:16:16.351+0900 D/rpm-installer(10469): dCBDbGFzczAeFw0xMzEyMzAxNTAxNDdaFw0yODEyMjYxNTAxNDdaMIGeMQswCQYDVQQGEwJLUjEU
05-05 01:16:16.351+0900 D/rpm-installer(10469): MBIGA1UECAwLU291dGggS29yZWExDjAMBgNVBAcMBVN1d29uMSYwJAYDVQQKDB1TYW1zdW5nIEVs
05-05 01:16:16.351+0900 D/rpm-installer(10469): ZWN0cm9uaWNzIENvLiwgTHRkLjEPMA0GA1UECwwGTW9iaWxlMTAwLgYDVQQDDCdTYW1zdW5nIFRp
05-05 01:16:16.351+0900 D/rpm-installer(10469): emVuIERFVkVMT1BFUiBQdWJsaWMgQ0EgQ2xhc3MwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEK
05-05 01:16:16.351+0900 D/rpm-installer(10469): AoIBAQCkqW9d0zO5NFOc7u164DKe9Yx+yEgUnsbhnJasqHaqT71qaMxyCOjyysZi7gGycDcgmLcU
05-05 01:16:16.351+0900 D/rpm-installer(10469): tr2wSMTGWPibK8SrJ8bV/J1cy9nTpljM3s+lbPIVVxZeufhJkU79tXImHLolERd0vui+rj0Xpd9O
05-05 01:16:16.351+0900 D/rpm-installer(10469): zlyNTRt0+PWVT1taWcbfHL7pUD25hMkTc8C3bC+dUoT1/RhCkXgmUvIor3EnnU0rBtAl4qNtg5y1
05-05 01:16:16.351+0900 D/rpm-installer(10469): 7RLT8dyicieAHCcW923YC/ngMZxnBjbL2Ht1RBUvrL6K3X5+l0VeF4qC3g7TKm/a/SGjq12ZD4sc
05-05 01:16:16.351+0900 D/rpm-installer(10469): 7rglzjSNlTVSGag6/2WkqxE6HheEBWaloYOdauzwydFNAgMBAAGjEDAOMAwGA1UdEwQFMAMBAf8w
05-05 01:16:16.351+0900 D/rpm-installer(10469): DQYJKoZI
05-05 01:16:16.351+0900 D/rpm-installer(10469): rpm-installer.c: _ri_verify_sig_and_cert(1911) > cert_svc_verify() starts, is_samsung_cert=[false]
05-05 01:16:16.351+0900 D/CERT_SVC(10469): cert-service-util.c: get_certificate_fingerprint(589) > fingerprint : 4B:C8:6B:BE:34:D6:A3:F7:5C:08:A0:35:EE:EB:D3:DE:A4:B8:0F:79
05-05 01:16:16.351+0900 D/CERT_SVC(10469): cert-service-util.c: get_visibility_by_fingerprint(598) > fingerprint : 4B:C8:6B:BE:34:D6:A3:F7:5C:08:A0:35:EE:EB:D3:DE:A4:B8:0F:79
05-05 01:16:16.351+0900 D/CERT_SVC(10469): cert-service-util.c: get_visibility_by_fingerprint(650) > fingerprint : 4B:C8:6B:BE:34:D6:A3:F7:5C:08:A0:35:EE:EB:D3:DE:A4:B8:0F:79 are tizen-public
05-05 01:16:16.351+0900 D/rpm-installer(10469): rpm-installer.c: _ri_verify_sig_and_cert(1923) > cert_svc_verify() is done successfully. validity=[1]
05-05 01:16:16.351+0900 D/rpm-installer(10469): rpm-installer.c: _ri_verify_sig_and_cert(1935) > Root CA cert path=[/usr/share/cert-svc/certs/code-signing/tizen/samsung_tizen_dev_public.pem]
05-05 01:16:16.471+0900 D/rpm-installer(10469): rpm-installer.c: __ri_verify_file(407) > valid signature
05-05 01:16:16.471+0900 D/rpm-installer(10469): rpm-installer.c: __ri_get_cert_from_file(1066) > Root CA, len=[1268]
05-05 01:16:16.471+0900 D/rpm-installer(10469): MIIDszCCApugAwIBAgIJALxYLI/Z7cqZMA0GCSqGSIb3DQEBCwUAMIGPMQswCQYDVQQGEwJLUjEUMBIGA1UECAwLU291dGggS29yZWExDjAMBgNVBAcMBVN1d29uMSYwJAYDVQQKDB1TYW1zdW5nIEVsZWN0cm9uaWNzIENvLiwgTHRkLjEyMDAGA1UEAwwpU2Ftc3VuZyBUaXplbiBERVZFTE9QRVIgUHVibGljIFJvb3QgQ2xhc3MwHhcNMTMxMjMwMTUwMTQyWhcNMzMxMjI1MTUwMTQyWjCBjzELMAkGA1UEBhMCS1IxFDASBgNVBAgMC1NvdXRoIEtvcmVhMQ4wDAYDVQQHDAVTdXdvbjEmMCQGA1UECgwdU2Ftc3VuZyBFbGVjdHJvbmljcyBDby4sIEx0ZC4xMjAwBgNVBAMMKVNhbXN1bmcgVGl6ZW4gREVWRUxPUEVSIFB1YmxpYyBSb290IENsYXNzMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAsBOg6dthhkQ5vY5QW2KXyMb2bwKqHLUqRj1GkdcOVWJA+rxBnRlfYVVBJv9MCecrLkieriWfHB3Tcn9fIUnGtSzj2X7An5Qg05toNkjuS7B73Pb+eHZ2vEFNmFf+FQBc6KzCg+fSBa63BZg/lQg+l97gSKE1KFzU8D8INWJd/Yn6Uespvmcbyp3nlKakfleVdEsYOQ3HTevPfnoClRYsCI4R5/rFM4h6GzO2X8IEDhLgMc/Q8VWH/CoRkGwww7C//ofutdNs2WCF8FISyiSJq+sDXHlyGXKtZ+7ArKdLpe3xOZGGY2NJOV7H1v0vtJZeJSFPcoVd5csKgURu9v/7twIDAQABoxAwDjAMBgNVHRMEBTADAQH/MA0GCSqGSIb3DQEBCwUAA4IBAQBY+gZZPQ6MYkIrYB6JmaorVncOwy
05-05 01:16:16.471+0900 D/CERT_SVC(10469): cert-service-util.c: get_certificate_fingerprint(589) > fingerprint : 4B:C8:6B:BE:34:D6:A3:F7:5C:08:A0:35:EE:EB:D3:DE:A4:B8:0F:79
05-05 01:16:16.471+0900 D/CERT_SVC(10469): cert-service-util.c: get_visibility_by_fingerprint(598) > fingerprint : 4B:C8:6B:BE:34:D6:A3:F7:5C:08:A0:35:EE:EB:D3:DE:A4:B8:0F:79
05-05 01:16:16.471+0900 D/CERT_SVC(10469): cert-service-util.c: get_visibility_by_fingerprint(650) > fingerprint : 4B:C8:6B:BE:34:D6:A3:F7:5C:08:A0:35:EE:EB:D3:DE:A4:B8:0F:79 are tizen-public
05-05 01:16:16.471+0900 D/rpm-installer(10469): rpm-installer.c: _ri_verify_sig_and_cert(1959) > cert_svc_get_visibility() returns visibility=[64]
05-05 01:16:16.471+0900 D/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_verify_signatures(822) > _ri_verify_sig_and_cert() succeed, path=[/opt/usr/apps/org.tizen.helloworld/signature1.xml]
05-05 01:16:16.471+0900 D/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_package_reinstall(3163) > signature and certificate verifying success
05-05 01:16:16.501+0900 E/PKGMGR_CERT(10469): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(427) > Transaction Begin
05-05 01:16:16.501+0900 E/PKGMGR_CERT(10469): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 10 1
05-05 01:16:16.501+0900 E/PKGMGR_CERT(10469): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 11 1
05-05 01:16:16.501+0900 E/PKGMGR_CERT(10469): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 12 1
05-05 01:16:16.501+0900 E/PKGMGR_CERT(10469): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 13 1
05-05 01:16:16.501+0900 E/PKGMGR_CERT(10469): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 14 1
05-05 01:16:16.501+0900 E/PKGMGR_CERT(10469): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(496) > Id:Count = 15 1
05-05 01:16:16.501+0900 D/PKGMGR  ( 2210): comm_client_gdbus.c: _on_signal_handle_filter(177) > [SECURE_LOG] Got signal: [status] org.tizen.helloworld_-509526583 / coretpk / org.tizen.helloworld / install_percent / 60
05-05 01:16:16.501+0900 D/PKGMGR  ( 2210): pkgmgr.c: __status_callback(391) > [SECURE_LOG] __status_callback() req_id[org.tizen.helloworld_-509526583] pkg_type[coretpk] pkgid[org.tizen.helloworld]key[install_percent] val[60]
05-05 01:16:16.501+0900 D/QUICKPANEL( 2210): uninstall.c: _pkgmgr_event_cb(79) > [SECURE_LOG] [_pkgmgr_event_cb : 79] pkg:org.tizen.helloworld key:install_percent val:60
05-05 01:16:16.501+0900 D/PKGMGR  ( 2210): comm_client_gdbus.c: _on_signal_handle_filter(183) > callback function is end
05-05 01:16:16.501+0900 D/PKGMGR  ( 2210): comm_client_gdbus.c: _on_signal_handle_filter(185) > Handled signal. Exit function
05-05 01:16:16.501+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(177) > [SECURE_LOG] Got signal: [status] org.tizen.helloworld_-509526583 / coretpk / org.tizen.helloworld / install_percent / 60
05-05 01:16:16.501+0900 D/PKGMGR  ( 2340): pkgmgr.c: __status_callback(391) > [SECURE_LOG] __status_callback() req_id[org.tizen.helloworld_-509526583] pkg_type[coretpk] pkgid[org.tizen.helloworld]key[install_percent] val[60]
05-05 01:16:16.501+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(183) > callback function is end
05-05 01:16:16.501+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(185) > Handled signal. Exit function
05-05 01:16:16.501+0900 D/PKGMGR  ( 2196): comm_client_gdbus.c: _on_signal_handle_filter(177) > [SECURE_LOG] Got signal: [status] org.tizen.helloworld_-509526583 / coretpk / org.tizen.helloworld / install_percent / 60
05-05 01:16:16.501+0900 D/PKGMGR  ( 2196): pkgmgr.c: __status_callback(391) > [SECURE_LOG] __status_callback() req_id[org.tizen.helloworld_-509526583] pkg_type[coretpk] pkgid[org.tizen.helloworld]key[install_percent] val[60]
05-05 01:16:16.501+0900 D/MENU_SCREEN( 2196): pkgmgr.c: _pkgmgr_cb(587) > pkgmgr request [install_percent:60] for org.tizen.helloworld
05-05 01:16:16.501+0900 D/MENU_SCREEN( 2196): pkgmgr.c: _install_percent(447) > package(org.tizen.helloworld) with 60
05-05 01:16:16.501+0900 D/PKGMGR  ( 2196): comm_client_gdbus.c: _on_signal_handle_filter(183) > callback function is end
05-05 01:16:16.501+0900 D/PKGMGR  ( 2196): comm_client_gdbus.c: _on_signal_handle_filter(185) > Handled signal. Exit function
05-05 01:16:16.501+0900 D/PKGMGR  ( 2211): comm_client_gdbus.c: _on_signal_handle_filter(177) > [SECURE_LOG] Got signal: [status] org.tizen.helloworld_-509526583 / coretpk / org.tizen.helloworld / install_percent / 60
05-05 01:16:16.501+0900 D/PKGMGR  ( 2211): pkgmgr.c: __status_callback(391) > [SECURE_LOG] __status_callback() req_id[org.tizen.helloworld_-509526583] pkg_type[coretpk] pkgid[org.tizen.helloworld]key[install_percent] val[60]
05-05 01:16:16.501+0900 D/PKGMGR  ( 2211): comm_client_gdbus.c: _on_signal_handle_filter(183) > callback function is end
05-05 01:16:16.501+0900 D/PKGMGR  ( 2211): comm_client_gdbus.c: _on_signal_handle_filter(185) > Handled signal. Exit function
05-05 01:16:16.501+0900 D/PKGMGR  ( 1921): comm_client_gdbus.c: _on_signal_handle_filter(177) > [SECURE_LOG] Got signal: [status] org.tizen.helloworld_-509526583 / coretpk / org.tizen.helloworld / install_percent / 60
05-05 01:16:16.501+0900 D/PKGMGR  ( 1921): pkgmgr.c: __status_callback(391) > [SECURE_LOG] __status_callback() req_id[org.tizen.helloworld_-509526583] pkg_type[coretpk] pkgid[org.tizen.helloworld]key[install_percent] val[60]
05-05 01:16:16.501+0900 D/DATA_PROVIDER_MASTER( 1921): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.tizen.helloworld] 60
05-05 01:16:16.501+0900 D/PKGMGR  ( 1921): comm_client_gdbus.c: _on_signal_handle_filter(183) > callback function is end
05-05 01:16:16.501+0900 D/PKGMGR  ( 1921): comm_client_gdbus.c: _on_signal_handle_filter(185) > Handled signal. Exit function
05-05 01:16:16.911+0900 E/PKGMGR_CERT(10469): pkgmgrinfo_certinfo.c: pkgmgrinfo_save_certinfo(571) > Transaction Commit and End
05-05 01:16:16.911+0900 E/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_make_directory(1490) > mkdir failed. appdir=[/usr/apps/org.tizen.helloworld/shared], errno=[2][No such file or directory]
05-05 01:16:16.911+0900 E/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1123) > skip! empty dirpath=[/usr/apps/org.tizen.helloworld/shared]
05-05 01:16:16.911+0900 E/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1123) > skip! empty dirpath=[/opt/usr/apps/org.tizen.helloworld/shared/data]
05-05 01:16:16.911+0900 E/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_apply_directory_policy(1123) > skip! empty dirpath=[/usr/apps/org.tizen.helloworld/shared/res]
05-05 01:16:16.911+0900 E/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_apply_file_policy(1108) > skip! empty filepath=[/usr/apps/org.tizen.helloworld/tizen-manifest.xml]
05-05 01:16:16.911+0900 E/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_apply_file_policy(1108) > skip! empty filepath=[/usr/apps/org.tizen.helloworld/author-signature.xml]
05-05 01:16:16.911+0900 E/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_apply_file_policy(1108) > skip! empty filepath=[/usr/apps/org.tizen.helloworld/signature1.xml]
05-05 01:16:16.911+0900 E/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_apply_file_policy(1108) > skip! empty filepath=[/usr/share/packages/org.tizen.helloworld.xml]
05-05 01:16:16.911+0900 D/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_make_directory_for_ext(1353) > Directory dose not exist. path: /opt/usr/apps/org.tizen.helloworld/shared/data, errno: 2 (No such file or directory)
05-05 01:16:17.451+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_unregister_package(74) > [smack] app_uninstall(org.tizen.helloworld), result=[0]
05-05 01:16:17.831+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_register_package(64) > [smack] app_install(org.tizen.helloworld), result=[0]
05-05 01:16:17.831+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_setup_path(113) > [smack] app_setup_path(org.tizen.helloworld, /opt/usr/apps/org.tizen.helloworld, 5, _), result=[0]
05-05 01:16:17.831+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_setup_path(113) > [smack] app_setup_path(org.tizen.helloworld, /opt/usr/apps/org.tizen.helloworld/shared, 5, _), result=[0]
05-05 01:16:17.831+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_setup_path(113) > [smack] app_setup_path(org.tizen.helloworld, /opt/usr/apps/org.tizen.helloworld/shared/res, 5, _), result=[0]
05-05 01:16:17.831+0900 E/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_get_smack_label_access(627) > Error in getting smack ACCESS label failed. result[-1] (path:[/opt/usr/apps/org.tizen.helloworld/shared/data]))
05-05 01:16:17.831+0900 D/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_get_group_id(1770) > encoding done, len=[28]
05-05 01:16:17.831+0900 D/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_apply_smack(1878) > groupid = [5NtptWCIlH9tjd0NymGr80bOuS8=] for shared/trusted.
05-05 01:16:17.991+0900 D/PKGMGR_SERVER(10468): pkgmgr-server.c: exit_server(667) > exit_server Start
05-05 01:16:18.141+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_setup_path(113) > [smack] app_setup_path(org.tizen.helloworld, /opt/usr/apps/org.tizen.helloworld/shared/trusted, 1, 5NtptWCIlH9tjd0NymGr80bOuS8=), result=[0]
05-05 01:16:18.141+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_setup_path(113) > [smack] app_setup_path(org.tizen.helloworld, /opt/usr/apps/org.tizen.helloworld/bin, 0, org.tizen.helloworld), result=[0]
05-05 01:16:18.141+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_setup_path(113) > [smack] app_setup_path(org.tizen.helloworld, /opt/usr/apps/org.tizen.helloworld/data, 0, org.tizen.helloworld), result=[0]
05-05 01:16:18.141+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_setup_path(113) > [smack] app_setup_path(org.tizen.helloworld, /opt/usr/apps/org.tizen.helloworld/lib, 0, org.tizen.helloworld), result=[0]
05-05 01:16:18.141+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_setup_path(113) > [smack] app_setup_path(org.tizen.helloworld, /opt/usr/apps/org.tizen.helloworld/res, 0, org.tizen.helloworld), result=[0]
05-05 01:16:18.141+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_setup_path(113) > [smack] app_setup_path(org.tizen.helloworld, /opt/usr/apps/org.tizen.helloworld/cache, 0, org.tizen.helloworld), result=[0]
05-05 01:16:18.141+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_setup_path(113) > [smack] app_setup_path(org.tizen.helloworld, /opt/usr/apps/org.tizen.helloworld/tizen-manifest.xml, 0, org.tizen.helloworld), result=[0]
05-05 01:16:18.141+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_setup_path(113) > [smack] app_setup_path(org.tizen.helloworld, /opt/usr/apps/org.tizen.helloworld/author-signature.xml, 0, org.tizen.helloworld), result=[0]
05-05 01:16:18.141+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_setup_path(113) > [smack] app_setup_path(org.tizen.helloworld, /opt/usr/apps/org.tizen.helloworld/signature1.xml, 0, org.tizen.helloworld), result=[0]
05-05 01:16:18.141+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_setup_path(113) > [smack] app_setup_path(org.tizen.helloworld, /opt/share/packages/org.tizen.helloworld.xml, 0, org.tizen.helloworld), result=[0]
05-05 01:16:18.141+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_setup_path(113) > [smack] app_setup_path(org.tizen.helloworld, /opt/storage/sdcard/apps/org.tizen.helloworld, 5, _), result=[0]
05-05 01:16:18.141+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_setup_path(113) > [smack] app_setup_path(org.tizen.helloworld, /opt/storage/sdcard/apps/org.tizen.helloworld/data, 0, org.tizen.helloworld), result=[0]
05-05 01:16:18.141+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_setup_path(113) > [smack] app_setup_path(org.tizen.helloworld, /opt/storage/sdcard/apps/org.tizen.helloworld/cache, 0, org.tizen.helloworld), result=[0]
05-05 01:16:18.141+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_setup_path(113) > [smack] app_setup_path(org.tizen.helloworld, /opt/storage/sdcard/apps/org.tizen.helloworld/shared, 5, _), result=[0]
05-05 01:16:18.141+0900 D/rpm-installer(10469): rpm-installer.c: __privilege_func(1086) > package_id = [org.tizen.helloworld], privilege = [http://tizen.org/privilege/systemsettings]
05-05 01:16:18.141+0900 D/rpm-installer(10469): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
05-05 01:16:18.141+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_enable_permissions(97) > [smack] app_enable_permissions(org.tizen.helloworld, 7), result=[0]
05-05 01:16:18.571+0900 D/rpm-installer(10469): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
05-05 01:16:18.571+0900 D/rpm-installer(10469): rpm-installer.c: __privilege_func(1112) > _ri_privilege_enable_permissions(org.tizen.helloworld, 7) succeed.
05-05 01:16:18.571+0900 D/rpm-installer(10469): rpm-installer-privilege.c: __ri_privilege_perm_begin(44) > [smack] perm_begin, result=[0]
05-05 01:16:18.571+0900 D/rpm-installer(10469): rpm-installer-privilege.c: _ri_privilege_enable_permissions(97) > [smack] app_enable_permissions(org.tizen.helloworld, 7), result=[0]
05-05 01:16:18.931+0900 D/rpm-installer(10469): rpm-installer-privilege.c: __ri_privilege_perm_end(54) > [smack] perm_end, result=[0]
05-05 01:16:18.931+0900 D/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_package_reinstall(3236) > #permission applying success.
05-05 01:16:18.931+0900 D/PRIVILEGE_INFO(10469): privilege_info.c: privilege_manager_verify_privilege_list(739) > privilege_info_compare_privilege_level called
05-05 01:16:18.931+0900 D/PRIVILEGE_INFO(10469): privilege_info.c: privilege_manager_verify_privilege_list(755) > Checking privilege : http://tizen.org/privilege/systemsettings
05-05 01:16:18.931+0900 D/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_verify_privilege_list(672) > privilege_manager_verify_privilege_list(PRVMGR_PACKAGE_TYPE_CORE) is ok.
05-05 01:16:18.931+0900 D/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_package_reinstall(3244) > _coretpk_installer_verify_privilege_list(PRVMGR_PACKAGE_TYPE_CORE) is ok.
05-05 01:16:18.931+0900 D/PKGMGR  ( 2210): comm_client_gdbus.c: _on_signal_handle_filter(177) > [SECURE_LOG] Got signal: [status] org.tizen.helloworld_-509526583 / coretpk / org.tizen.helloworld / install_percent / 100
05-05 01:16:18.931+0900 D/PKGMGR  ( 2210): pkgmgr.c: __status_callback(391) > [SECURE_LOG] __status_callback() req_id[org.tizen.helloworld_-509526583] pkg_type[coretpk] pkgid[org.tizen.helloworld]key[install_percent] val[100]
05-05 01:16:18.931+0900 D/QUICKPANEL( 2210): uninstall.c: _pkgmgr_event_cb(79) > [SECURE_LOG] [_pkgmgr_event_cb : 79] pkg:org.tizen.helloworld key:install_percent val:100
05-05 01:16:18.931+0900 D/PKGMGR  ( 2210): comm_client_gdbus.c: _on_signal_handle_filter(183) > callback function is end
05-05 01:16:18.931+0900 D/PKGMGR  ( 2210): comm_client_gdbus.c: _on_signal_handle_filter(185) > Handled signal. Exit function
05-05 01:16:18.931+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(177) > [SECURE_LOG] Got signal: [status] org.tizen.helloworld_-509526583 / coretpk / org.tizen.helloworld / install_percent / 100
05-05 01:16:18.931+0900 D/PKGMGR  ( 2340): pkgmgr.c: __status_callback(391) > [SECURE_LOG] __status_callback() req_id[org.tizen.helloworld_-509526583] pkg_type[coretpk] pkgid[org.tizen.helloworld]key[install_percent] val[100]
05-05 01:16:18.931+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(183) > callback function is end
05-05 01:16:18.931+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(185) > Handled signal. Exit function
05-05 01:16:18.931+0900 D/PKGMGR  ( 2196): comm_client_gdbus.c: _on_signal_handle_filter(177) > [SECURE_LOG] Got signal: [status] org.tizen.helloworld_-509526583 / coretpk / org.tizen.helloworld / install_percent / 100
05-05 01:16:18.931+0900 D/PKGMGR  ( 2196): pkgmgr.c: __status_callback(391) > [SECURE_LOG] __status_callback() req_id[org.tizen.helloworld_-509526583] pkg_type[coretpk] pkgid[org.tizen.helloworld]key[install_percent] val[100]
05-05 01:16:18.931+0900 D/MENU_SCREEN( 2196): pkgmgr.c: _pkgmgr_cb(587) > pkgmgr request [install_percent:100] for org.tizen.helloworld
05-05 01:16:18.931+0900 D/MENU_SCREEN( 2196): pkgmgr.c: _install_percent(447) > package(org.tizen.helloworld) with 100
05-05 01:16:18.931+0900 D/PKGMGR  ( 2196): comm_client_gdbus.c: _on_signal_handle_filter(183) > callback function is end
05-05 01:16:18.931+0900 D/PKGMGR  ( 2196): comm_client_gdbus.c: _on_signal_handle_filter(185) > Handled signal. Exit function
05-05 01:16:18.931+0900 D/PKGMGR  ( 2211): comm_client_gdbus.c: _on_signal_handle_filter(177) > [SECURE_LOG] Got signal: [status] org.tizen.helloworld_-509526583 / coretpk / org.tizen.helloworld / install_percent / 100
05-05 01:16:18.931+0900 D/PKGMGR  ( 2211): pkgmgr.c: __status_callback(391) > [SECURE_LOG] __status_callback() req_id[org.tizen.helloworld_-509526583] pkg_type[coretpk] pkgid[org.tizen.helloworld]key[install_percent] val[100]
05-05 01:16:18.931+0900 D/PKGMGR  ( 2211): comm_client_gdbus.c: _on_signal_handle_filter(183) > callback function is end
05-05 01:16:18.931+0900 D/PKGMGR  ( 2211): comm_client_gdbus.c: _on_signal_handle_filter(185) > Handled signal. Exit function
05-05 01:16:18.931+0900 D/PKGMGR  ( 1921): comm_client_gdbus.c: _on_signal_handle_filter(177) > [SECURE_LOG] Got signal: [status] org.tizen.helloworld_-509526583 / coretpk / org.tizen.helloworld / install_percent / 100
05-05 01:16:18.931+0900 D/PKGMGR  ( 1921): pkgmgr.c: __status_callback(391) > [SECURE_LOG] __status_callback() req_id[org.tizen.helloworld_-509526583] pkg_type[coretpk] pkgid[org.tizen.helloworld]key[install_percent] val[100]
05-05 01:16:18.931+0900 D/DATA_PROVIDER_MASTER( 1921): pkgmgr.c: progress_cb(374) > [SECURE_LOG] [org.tizen.helloworld] 100
05-05 01:16:18.931+0900 D/PKGMGR  ( 1921): comm_client_gdbus.c: _on_signal_handle_filter(183) > callback function is end
05-05 01:16:18.931+0900 D/PKGMGR  ( 1921): comm_client_gdbus.c: _on_signal_handle_filter(185) > Handled signal. Exit function
05-05 01:16:18.931+0900 D/rpm-installer(10469): coretpk-installer.c: _coretpk_installer_package_reinstall(3261) > [#]end : _coretpk_installer_package_reinstall
05-05 01:16:18.931+0900 D/PKGMGR  ( 2211): comm_client_gdbus.c: _on_signal_handle_filter(177) > [SECURE_LOG] Got signal: [status] org.tizen.helloworld_-509526583 / coretpk / org.tizen.helloworld / end / ok
05-05 01:16:18.931+0900 D/PKGMGR  ( 2211): pkgmgr.c: __status_callback(391) > [SECURE_LOG] __status_callback() req_id[org.tizen.helloworld_-509526583] pkg_type[coretpk] pkgid[org.tizen.helloworld]key[end] val[ok]
05-05 01:16:18.931+0900 D/PKGMGR  ( 2211): comm_client_gdbus.c: _on_signal_handle_filter(183) > callback function is end
05-05 01:16:18.931+0900 D/PKGMGR  ( 2211): comm_client_gdbus.c: _on_signal_handle_filter(185) > Handled signal. Exit function
05-05 01:16:18.931+0900 D/PKGMGR  ( 1921): comm_client_gdbus.c: _on_signal_handle_filter(177) > [SECURE_LOG] Got signal: [status] org.tizen.helloworld_-509526583 / coretpk / org.tizen.helloworld / end / ok
05-05 01:16:18.931+0900 D/PKGMGR  ( 1921): pkgmgr.c: __status_callback(391) > [SECURE_LOG] __status_callback() req_id[org.tizen.helloworld_-509526583] pkg_type[coretpk] pkgid[org.tizen.helloworld]key[end] val[ok]
05-05 01:16:18.931+0900 D/DATA_PROVIDER_MASTER( 1921): pkgmgr.c: end_cb(409) > [SECURE_LOG] [org.tizen.helloworld] ok
05-05 01:16:18.931+0900 D/PKGMGR  ( 1921): comm_client_gdbus.c: _on_signal_handle_filter(183) > callback function is end
05-05 01:16:18.931+0900 D/PKGMGR  ( 1921): comm_client_gdbus.c: _on_signal_handle_filter(185) > Handled signal. Exit function
05-05 01:16:18.931+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(177) > [SECURE_LOG] Got signal: [status] org.tizen.helloworld_-509526583 / coretpk / org.tizen.helloworld / end / ok
05-05 01:16:18.931+0900 D/PKGMGR  ( 2340): pkgmgr.c: __status_callback(391) > [SECURE_LOG] __status_callback() req_id[org.tizen.helloworld_-509526583] pkg_type[coretpk] pkgid[org.tizen.helloworld]key[end] val[ok]
05-05 01:16:18.931+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(183) > callback function is end
05-05 01:16:18.931+0900 D/PKGMGR  ( 2340): comm_client_gdbus.c: _on_signal_handle_filter(185) > Handled signal. Exit function
05-05 01:16:18.931+0900 D/PKGMGR  ( 2196): comm_client_gdbus.c: _on_signal_handle_filter(177) > [SECURE_LOG] Got signal: [status] org.tizen.helloworld_-509526583 / coretpk / org.tizen.helloworld / end / ok
05-05 01:16:18.931+0900 D/PKGMGR  ( 2196): pkgmgr.c: __status_callback(391) > [SECURE_LOG] __status_callback() req_id[org.tizen.helloworld_-509526583] pkg_type[coretpk] pkgid[org.tizen.helloworld]key[end] val[ok]
05-05 01:16:18.931+0900 D/MENU_SCREEN( 2196): pkgmgr.c: _pkgmgr_cb(587) > pkgmgr request [end:ok] for org.tizen.helloworld
05-05 01:16:18.931+0900 D/MENU_SCREEN( 2196): pkgmgr.c: _end(527) > Package(org.tizen.helloworld) : key(update) - val(ok)
05-05 01:16:18.931+0900 D/MENU_SCREEN( 2196): layout.c: layout_create_package(195) > Package org.tizen.helloworld is found, update it!
05-05 01:16:18.931+0900 D/MENU_SCREEN( 2196): item.c: item_update(595) > Access to file [/opt/usr/apps/org.tizen.helloworld/shared/res/Koala.png], size[33895]
05-05 01:16:18.931+0900 D/BADGE   ( 2196): badge_internal.c: _badge_check_data_inserted(154) > [SECURE_LOG] [_badge_check_data_inserted : 154] [SELECT count(*) FROM badge_data WHERE pkgname = 'org.tizen.helloworld'], count[0]
05-05 01:16:18.931+0900 D/PKGMGR  ( 2196): comm_client_gdbus.c: _on_signal_handle_filter(183) > callback function is end
05-05 01:16:18.931+0900 D/PKGMGR  ( 2196): comm_client_gdbus.c: _on_signal_handle_filter(185) > Handled signal. Exit function
05-05 01:16:18.931+0900 D/PKGMGR  ( 2210): comm_client_gdbus.c: _on_signal_handle_filter(177) > [SECURE_LOG] Got signal: [status] org.tizen.helloworld_-509526583 / coretpk / org.tizen.helloworld / end / ok
05-05 01:16:18.931+0900 D/PKGMGR  ( 2210): pkgmgr.c: __status_callback(391) > [SECURE_LOG] __status_callback() req_id[org.tizen.helloworld_-509526583] pkg_type[coretpk] pkgid[org.tizen.helloworld]key[end] val[ok]
05-05 01:16:18.931+0900 D/QUICKPANEL( 2210): uninstall.c: _pkgmgr_event_cb(79) > [SECURE_LOG] [_pkgmgr_event_cb : 79] pkg:org.tizen.helloworld key:end val:ok
05-05 01:16:18.931+0900 D/PKGMGR  ( 2210): comm_client_gdbus.c: _on_signal_handle_filter(183) > callback function is end
05-05 01:16:18.931+0900 D/PKGMGR  ( 2210): comm_client_gdbus.c: _on_signal_handle_filter(185) > Handled signal. Exit function
05-05 01:16:18.931+0900 D/PKGMGR  ( 2017): comm_client_gdbus.c: _on_signal_handle_filter(177) > [SECURE_LOG] Got signal: [upgrade] org.tizen.helloworld_-509526583 / coretpk / org.tizen.helloworld / end / ok
05-05 01:16:18.931+0900 D/PKGMGR  ( 2017): pkgmgr.c: __status_callback(391) > [SECURE_LOG] __status_callback() req_id[org.tizen.helloworld_-509526583] pkg_type[coretpk] pkgid[org.tizen.helloworld]key[end] val[ok]
05-05 01:16:18.931+0900 D/AUL_AMD ( 2017): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(538) > [SECURE_LOG] pkgid(org.tizen.helloworld), key(end), value(ok)
05-05 01:16:18.931+0900 D/AUL_AMD ( 2017): amd_appinfo.c: __amd_pkgmgrinfo_status_cb(559) > [SECURE_LOG] op(update), value(ok)
05-05 01:16:18.931+0900 D/AUL_AMD ( 2017): amd_appinfo.c: __app_info_insert_handler(185) > __app_info_insert_handler
05-05 01:16:18.931+0900 D/AUL_AMD ( 2017): amd_appinfo.c: __app_info_insert_handler(388) > [SECURE_LOG] appinfo file:org.tizen.helloworld, comp:ui, type:rpm
05-05 01:16:18.931+0900 D/PKGMGR  ( 2017): comm_client_gdbus.c: _on_signal_handle_filter(183) > callback function is end
05-05 01:16:18.931+0900 D/PKGMGR  ( 2017): comm_client_gdbus.c: _on_signal_handle_filter(185) > Handled signal. Exit function
05-05 01:16:18.931+0900 D/RESOURCED( 2244): proc-monitor.c: proc_dbus_active_signal_handler(107) > [proc_dbus_active_signal_handler,107] call dbus_proc_active_signal_handler
05-05 01:16:18.931+0900 D/rpm-installer(10469): rpm-appcore-intf.c: main(245) > ------------------------------------------------
05-05 01:16:18.931+0900 D/rpm-installer(10469): rpm-appcore-intf.c: main(246) >  [END] rpm-installer: result=[0]
05-05 01:16:18.931+0900 D/rpm-installer(10469): rpm-appcore-intf.c: main(247) > ------------------------------------------------
05-05 01:16:18.951+0900 D/LBS_DBUS_SERVER( 2318): lbs_dbus_server.c: on_name_owner_changed(543) > [SECURE_LOG] service_name com.samsung.slp.pkgmgr_status, prev_owner :1.413, new_owner 
05-05 01:16:18.951+0900 D/LBS_DBUS_SERVER( 2318): lbs_dbus_server.c: on_name_owner_changed(543) > [SECURE_LOG] service_name :1.413, prev_owner :1.413, new_owner 
05-05 01:16:18.951+0900 D/PKGMGR_SERVER(10468): pkgmgr-server.c: sighandler(322) > child exit [10469]
05-05 01:16:18.951+0900 D/PKGMGR_SERVER(10468): pkgmgr-server.c: sighandler(337) > child NORMAL exit [10469]
05-05 01:16:18.951+0900 D/LBS_DBUS_SERVER( 2318): lbs_dbus_server.c: on_name_owner_changed(543) > [SECURE_LOG] service_name :1.411, prev_owner :1.411, new_owner 
05-05 01:16:19.991+0900 D/PKGMGR_SERVER(10468): pkgmgr-server.c: exit_server(667) > exit_server Start
05-05 01:16:19.991+0900 D/PKGMGR_SERVER(10468): pkgmgr-server.c: main(1435) > Quit main loop.
05-05 01:16:19.991+0900 D/PKGMGR_SERVER(10468): pkgmgr-server.c: main(1443) > package manager server terminated.
05-05 01:16:19.991+0900 D/LBS_DBUS_SERVER( 2318): lbs_dbus_server.c: on_name_owner_changed(543) > [SECURE_LOG] service_name com.samsung.slp.pkgmgr, prev_owner :1.412, new_owner 
05-05 01:16:19.991+0900 D/LBS_DBUS_SERVER( 2318): lbs_dbus_server.c: on_name_owner_changed(543) > [SECURE_LOG] service_name :1.412, prev_owner :1.412, new_owner 
05-05 01:16:20.451+0900 D/AUL_AMD ( 2017): amd_request.c: __request_handler(491) > __request_handler: 0
05-05 01:16:20.451+0900 D/AUL     ( 2017): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 10518, pid = 10520
05-05 01:16:20.451+0900 D/AUL_AMD ( 2017): amd_launch.c: _start_app(1464) > [SECURE_LOG] caller : (null)
05-05 01:16:20.451+0900 D/AUL_AMD ( 2017): amd_launch.c: _start_app(1768) > process_pool: false
05-05 01:16:20.451+0900 D/AUL_AMD ( 2017): amd_launch.c: _start_app(1771) > h/w acceleration: SYS
05-05 01:16:20.451+0900 D/AUL_AMD ( 2017): amd_launch.c: _start_app(1773) > [SECURE_LOG] appid: org.tizen.helloworld
05-05 01:16:20.451+0900 D/AUL_AMD ( 2017): amd_launch.c: __set_appinfo_for_launchpad(1925) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-05 01:16:20.451+0900 D/AUL     ( 2017): app_sock.c: __app_send_raw(264) > pid(-1) : cmd(0)
05-05 01:16:20.451+0900 D/AUL_PAD ( 2023): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.tizen.helloworld
05-05 01:16:20.451+0900 D/AUL_PAD ( 2023): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
05-05 01:16:20.451+0900 D/AUL_PAD ( 2023): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 10521 /opt/usr/apps/org.tizen.helloworld/bin/helloworld
05-05 01:16:20.451+0900 D/AUL_PAD ( 2023): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
05-05 01:16:20.451+0900 D/AUL_PAD (10521): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
05-05 01:16:20.451+0900 D/AUL_PAD (10521): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
05-05 01:16:20.451+0900 D/AUL_PAD (10521): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.tizen.helloworld / pkg_type : rpm / app_path : /opt/usr/apps/org.tizen.helloworld/bin/helloworld 
05-05 01:16:20.451+0900 D/AUL_PAD (10521): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
05-05 01:16:20.451+0900 D/AUL_PAD (10521): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.tizen.helloworld/bin/helloworld##
05-05 01:16:20.451+0900 D/AUL_PAD (10521): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
05-05 01:16:20.451+0900 D/AUL_PAD (10521): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
05-05 01:16:20.451+0900 D/LAUNCH  (10521): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.tizen.helloworld/bin/helloworld:Platform:launchpad:done]
05-05 01:16:20.451+0900 I/CAPI_APPFW_APPLICATION(10521): app_main.c: ui_app_main(694) > app_efl_main
05-05 01:16:20.451+0900 D/LAUNCH  (10521): appcore-efl.c: appcore_efl_main(1548) > [helloworld:Application:main:done]
05-05 01:16:20.481+0900 D/APP_CORE(10521): appcore-efl.c: __before_loop(996) > elm_config_preferred_engine_set is not called
05-05 01:16:20.481+0900 D/AUL     (10521): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 10521 is org.tizen.helloworld
05-05 01:16:20.481+0900 D/APP_CORE(10521): appcore.c: appcore_init(502) > [SECURE_LOG] dir : /usr/apps/org.tizen.helloworld/res/locale
05-05 01:16:20.481+0900 D/APP_CORE(10521): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_US.UTF-8
05-05 01:16:20.481+0900 D/AUL     (10521): app_sock.c: __create_server_sock(135) > pg path - already exists
05-05 01:16:20.481+0900 D/LAUNCH  (10521): appcore-efl.c: __before_loop(1014) > [helloworld:Platform:appcore_init:done]
05-05 01:16:20.481+0900 I/CAPI_APPFW_APPLICATION(10521): app_main.c: _ui_app_appcore_create(555) > app_appcore_create
05-05 01:16:20.491+0900 D/APP_CORE(10521): appcore-rotation.c: __dbus_signal_handler_init_with_param(257) > app signal initialized
05-05 01:16:20.551+0900 D/AUL_PAD ( 2023): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
05-05 01:16:20.551+0900 D/AUL_PAD ( 2023): sigchild.h: __send_app_launch_signal(112) > send launch signal done
05-05 01:16:20.551+0900 D/AUL_PAD ( 2023): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
05-05 01:16:20.551+0900 D/AUL     ( 2017): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
05-05 01:16:20.551+0900 E/AUL     ( 2017): simple_util.c: __trm_app_info_send_socket(264) > access
05-05 01:16:20.551+0900 D/AUL_AMD ( 2017): amd_main.c: __add_item_running_list(170) > [SECURE_LOG] __add_item_running_list pid: 10521
05-05 01:16:20.551+0900 D/AUL_AMD ( 2017): amd_main.c: __add_item_running_list(183) > [SECURE_LOG] __add_item_running_list appid: org.tizen.helloworld
05-05 01:16:20.571+0900 D/RESOURCED( 2244): proc-noti.c: recv_str(87) > [recv_str,87] str is null
05-05 01:16:20.571+0900 D/RESOURCED( 2244): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2017
05-05 01:16:20.571+0900 D/RESOURCED( 2244): proc-main.c: resourced_proc_action(687) > [SECURE_LOG] [resourced_proc_action,687] appid org.tizen.helloworld, pid 10521, type 4 
05-05 01:16:20.571+0900 D/RESOURCED( 2244): proc-main.c: resourced_proc_status_change(569) > [SECURE_LOG] [resourced_proc_status_change,569] launch request org.tizen.helloworld, 10521
05-05 01:16:20.571+0900 D/RESOURCED( 2244): proc-main.c: resourced_proc_status_change(571) > [SECURE_LOG] [resourced_proc_status_change,571] launch request org.tizen.helloworld with pkgname
05-05 01:16:20.571+0900 D/RESOURCED( 2244): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
05-05 01:16:20.621+0900 D/AUL_AMD ( 2017): amd_request.c: __request_handler(491) > __request_handler: 15
05-05 01:16:20.621+0900 D/AUL_AMD ( 2017): amd_status.c: _status_get_appid_bypid(457) > [SECURE_LOG] appid for 10521 is org.tizen.helloworld
05-05 01:16:20.621+0900 D/AUL_AMD ( 2017): amd_request.c: __request_handler(659) > APP_GET_APPID_BYPID : 10521 : 0
05-05 01:16:20.631+0900 D/AUL     ( 2177): app_sock.c: __app_send_cmd_with_result(608) > recv result  = 29
05-05 01:16:20.631+0900 D/AUL     ( 2177): app_sock.c: __app_send_raw(264) > pid(-2) : cmd(14)
05-05 01:16:20.631+0900 D/AUL_AMD ( 2017): amd_request.c: __request_handler(491) > __request_handler: 14
05-05 01:16:20.631+0900 D/AUL_AMD ( 2017): amd_request.c: __request_handler(652) > [SECURE_LOG] APP_IS_RUNNING : org.tizen.helloworld : 10521
05-05 01:16:20.631+0900 D/AUL_AMD ( 2017): amd_request.c: __send_result_to_client(69) > __send_result_to_client, res: 27
05-05 01:16:20.631+0900 D/AUL_AMD ( 2017): amd_request.c: __request_handler(491) > __request_handler: 12
05-05 01:16:20.631+0900 D/AUL     ( 2177): app_sock.c: __app_send_cmd_with_result(608) > recv result  = 375
05-05 01:16:20.631+0900 D/indicator( 2177): mp3_playing.c: music_app_terminate_cb(252) > music_app_terminate_cb[252]	 "music_app_terminate_cb"
05-05 01:16:21.001+0900 D/LAUNCH  (10521): appcore-efl.c: __before_loop(1024) > [helloworld:Application:create:done]
05-05 01:16:21.001+0900 D/APP_CORE(10521): appcore-efl.c: __check_wm_rotation_support(740) > Disable window manager rotation
05-05 01:16:21.051+0900 D/indicator( 2177): indicator_ui.c: _property_changed_cb(1189) > _property_changed_cb[1189]	 "UNSNIFF API 1a00002"
05-05 01:16:21.051+0900 D/indicator( 2177): indicator_ui.c: _active_indicator_handle(1098) > [SECURE_LOG] _active_indicator_handle[1098]	 "Type : 1, opacity 0, active_win 2a00003"
05-05 01:16:21.051+0900 D/indicator( 2177): indicator_util.c: indicator_signal_emit_by_win(144) > [SECURE_LOG] indicator_signal_emit_by_win[144]	 "emission 0 bg.opaque"
05-05 01:16:21.051+0900 D/indicator( 2177): indicator_ui.c: _active_indicator_handle(1104) > [SECURE_LOG] _active_indicator_handle[1104]	 "Type : 2, angle 0, active_win 2a00003"
05-05 01:16:21.051+0900 D/indicator( 2177): indicator_ui.c: _rotate_window(635) > _rotate_window[635]	 "_rotate_window = 0"
05-05 01:16:21.051+0900 D/AUL_AMD ( 2017): amd_launch.c: __e17_status_handler(1886) > pid(10521) status(3)
05-05 01:16:21.051+0900 D/RESOURCED( 2244): proc-monitor.c: proc_dbus_proc_signal_handler(181) > [proc_dbus_proc_signal_handler,181] call proc_dbus_proc_signal_handler : pid = 10521, type = 0
05-05 01:16:21.051+0900 D/RESOURCED( 2244): proc-main.c: resourced_proc_status_change(548) > [SECURE_LOG] [resourced_proc_status_change,548] set foreground : 10521
05-05 01:16:21.051+0900 D/RESOURCED( 2244): vmpressure-lowmem-handler.c: lowmem_move_memcgroup(1625) > [lowmem_move_memcgroup,1625] buf : /sys/fs/cgroup/memory/foreground1/cgroup.procs, pid : 10521, score : 200
05-05 01:16:21.051+0900 D/APP_CORE(10521): appcore.c: __aul_handler(403) > [APP 10521]     AUL event: AUL_START
05-05 01:16:21.051+0900 D/APP_CORE(10521): appcore-efl.c: __do_app(464) > [APP 10521] Event: RESET State: CREATED
05-05 01:16:21.051+0900 D/APP_CORE(10521): appcore-efl.c: __do_app(490) > [APP 10521] RESET
05-05 01:16:21.051+0900 D/LAUNCH  (10521): appcore-efl.c: __do_app(492) > [helloworld:Application:reset:start]
05-05 01:16:21.051+0900 I/CAPI_APPFW_APPLICATION(10521): app_main.c: _ui_app_appcore_reset(637) > app_appcore_reset
05-05 01:16:21.051+0900 D/APP_SVC (10521): appsvc.c: __set_bundle(161) > __set_bundle
05-05 01:16:21.051+0900 D/LAUNCH  (10521): appcore-efl.c: __do_app(495) > [helloworld:Application:reset:done]
05-05 01:16:21.051+0900 I/APP_CORE(10521): appcore-efl.c: __do_app(501) > Legacy lifecycle: 0
05-05 01:16:21.051+0900 I/APP_CORE(10521): appcore-efl.c: __do_app(503) > [APP 10521] Initial Launching, call the resume_cb
05-05 01:16:21.051+0900 I/CAPI_APPFW_APPLICATION(10521): app_main.c: _ui_app_appcore_resume(619) > app_appcore_resume
05-05 01:16:21.051+0900 D/APP_CORE(10521): appcore.c: __aul_handler(406) > [SECURE_LOG] caller_appid : (null)
05-05 01:16:21.051+0900 D/APP_CORE(10521): appcore-efl.c: __show_cb(814) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:2a00003
05-05 01:16:21.051+0900 D/APP_CORE(10521): appcore-efl.c: __add_win(660) > [EVENT_TEST][EVENT] __add_win WIN:2a00003
05-05 01:16:21.051+0900 D/APP_CORE(10521): appcore-efl.c: __update_win(706) > [EVENT_TEST][EVENT] __update_win WIN:2a00003 fully_obscured 0
05-05 01:16:21.051+0900 D/APP_CORE(10521): appcore-efl.c: __visibility_cb(869) > bvisibility 1, b_active -1
05-05 01:16:21.051+0900 D/APP_CORE(10521): appcore-efl.c: __visibility_cb(872) >  Go to Resume state
05-05 01:16:21.051+0900 D/APP_CORE(10521): appcore-efl.c: __do_app(464) > [APP 10521] Event: RESUME State: RUNNING
05-05 01:16:21.051+0900 D/LAUNCH  (10521): appcore-efl.c: __do_app(548) > [helloworld:Application:resume:start]
05-05 01:16:21.051+0900 D/LAUNCH  (10521): appcore-efl.c: __do_app(558) > [helloworld:Application:resume:done]
05-05 01:16:21.051+0900 D/LAUNCH  (10521): appcore-efl.c: __do_app(560) > [helloworld:Application:Launching:done]
05-05 01:16:21.051+0900 D/APP_CORE(10521): appcore-efl.c: __trm_app_info_send_socket(224) > __trm_app_info_send_socket
05-05 01:16:21.051+0900 E/APP_CORE(10521): appcore-efl.c: __trm_app_info_send_socket(227) > access
05-05 01:16:21.101+0900 D/RESOURCED( 2244): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 10521, appname = (null)
05-05 01:16:21.101+0900 D/RESOURCED( 2244): cgroup.c: cgroup_write_node(89) > [SECURE_LOG] [cgroup_write_node,89] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 10521
05-05 01:16:21.101+0900 D/RESOURCED( 2244): cgroup.c: cgroup_write_node(89) > [SECURE_LOG] [cgroup_write_node,89] cgroup_buf /sys/fs/cgroup/timer_slack/exclude/cgroup.procs, value 10521
05-05 01:16:21.101+0900 E/RESOURCED( 2244): file-helper.c: fwrite_str(50) > [fwrite_str,50] Fail to file open
05-05 01:16:21.101+0900 E/RESOURCED( 2244): file-helper.c: fwrite_str(50) > [fwrite_str,50] errno -2, errmsg No such file or directory
05-05 01:16:21.101+0900 I/RESOURCED( 2244): vmpressure-lowmem-handler.c: lowmem_cgroup_handler(1218) > [lowmem_cgroup_handler,1218] anon page (0) is under medium threshold (0)
05-05 01:16:21.191+0900 D/APP_CORE(10521): appcore.c: __prt_ltime(179) > [APP 10521] first idle after reset: 739 msec
05-05 01:16:21.201+0900 D/E17_EXTRA_MODULES( 1930): policy.c: _policy_active_win_change(2440) > [SECURE_LOG] [WM] ACT WIN 0x1a00002(2196) -> 0x2a00003(10521)
05-05 01:16:21.291+0900 D/E17_EXTRA_MODULES( 1930): policy.c: _policy_calculate_visibility(6074) > [SECURE_LOG] [WM] SEND VISIBILITY. win:0x2a00003 (old:2 -> new:0)
05-05 01:16:21.291+0900 D/E17_EXTRA_MODULES( 1930): policy.c: _policy_calculate_visibility(6074) > [SECURE_LOG] [WM] SEND VISIBILITY. win:0x1a00002 (old:0 -> new:2)
05-05 01:16:21.301+0900 D/APP_CORE(10521): appcore-efl.c: __update_win(706) > [EVENT_TEST][EVENT] __update_win WIN:2a00003 fully_obscured 0
05-05 01:16:21.301+0900 D/APP_CORE(10521): appcore-efl.c: __visibility_cb(869) > bvisibility 1, b_active 1
05-05 01:16:21.301+0900 D/APP_CORE(10521): appcore-efl.c: __visibility_cb(888) >  No change state 
05-05 01:16:21.301+0900 D/APP_CORE( 2196): appcore-efl.c: __update_win(706) > [EVENT_TEST][EVENT] __update_win WIN:1a00002 fully_obscured 1
05-05 01:16:21.301+0900 D/APP_CORE( 2196): appcore-efl.c: __visibility_cb(869) > bvisibility 0, b_active 1
05-05 01:16:21.301+0900 D/APP_CORE( 2196): appcore-efl.c: __visibility_cb(877) >  Go to Pasue state 
05-05 01:16:21.301+0900 D/APP_CORE( 2196): appcore-efl.c: __do_app(464) > [APP 2196] Event: PAUSE State: RUNNING
05-05 01:16:21.301+0900 D/APP_CORE( 2196): appcore-efl.c: __do_app(532) > [APP 2196] PAUSE
05-05 01:16:21.301+0900 I/CAPI_APPFW_APPLICATION( 2196): app_main.c: app_appcore_pause(194) > app_appcore_pause
05-05 01:16:21.301+0900 D/MENU_SCREEN( 2196): menu_screen.c: _pause_cb(539) > Pause start
05-05 01:16:21.301+0900 D/APP_CORE( 2196): appcore-efl.c: __trm_app_info_send_socket(224) > __trm_app_info_send_socket
05-05 01:16:21.301+0900 E/APP_CORE( 2196): appcore-efl.c: __trm_app_info_send_socket(227) > access
05-05 01:16:21.301+0900 D/RESOURCED( 2244): proc-monitor.c: proc_dbus_proc_signal_handler(181) > [proc_dbus_proc_signal_handler,181] call proc_dbus_proc_signal_handler : pid = 2196, type = 2
05-05 01:16:21.571+0900 D/AUL_AMD ( 2017): amd_request.c: __add_history_handler(243) > [SECURE_LOG] add rua history org.tizen.helloworld /opt/usr/apps/org.tizen.helloworld/bin/helloworld
05-05 01:16:21.571+0900 D/RUA     ( 2017): rua.c: rua_add_history(179) > rua_add_history start
05-05 01:16:21.571+0900 D/RUA     ( 2017): rua.c: rua_add_history(208) > query : REPLACE INTO rua_history(pkg_name,app_path,arg,launch_time) VALUES (?,?,?,?)
05-05 01:16:21.821+0900 D/RUA     ( 2017): rua.c: rua_add_history(249) > rua_add_history ok
05-05 01:16:22.741+0900 D/EFL     (10521): ecore_x<10521> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=31927755 button=1
05-05 01:16:22.871+0900 D/EFL     (10521): ecore_x<10521> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=31927877 button=1
05-05 01:16:22.891+0900 D/AUL_AMD ( 2017): amd_launch.c: __e17_status_handler(1886) > pid(2196) status(3)
05-05 01:16:22.891+0900 D/RESOURCED( 2244): proc-monitor.c: proc_dbus_proc_signal_handler(181) > [proc_dbus_proc_signal_handler,181] call proc_dbus_proc_signal_handler : pid = 2196, type = 0
05-05 01:16:22.891+0900 D/RESOURCED( 2244): proc-main.c: resourced_proc_status_change(548) > [SECURE_LOG] [resourced_proc_status_change,548] set foreground : 2196
05-05 01:16:22.891+0900 D/RESOURCED( 2244): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 2196, appname = (null)
05-05 01:16:22.891+0900 D/RESOURCED( 2244): cgroup.c: cgroup_write_node(89) > [SECURE_LOG] [cgroup_write_node,89] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 2196
05-05 01:16:22.891+0900 D/RESOURCED( 2244): cgroup.c: cgroup_write_node(89) > [SECURE_LOG] [cgroup_write_node,89] cgroup_buf /sys/fs/cgroup/timer_slack/exclude/cgroup.procs, value 2196
05-05 01:16:22.891+0900 E/RESOURCED( 2244): file-helper.c: fwrite_str(50) > [fwrite_str,50] Fail to file open
05-05 01:16:22.891+0900 E/RESOURCED( 2244): file-helper.c: fwrite_str(50) > [fwrite_str,50] errno -2, errmsg No such file or directory
05-05 01:16:22.951+0900 D/LBS_DBUS_SERVER( 2318): lbs_dbus_server.c: on_name_owner_changed(543) > [SECURE_LOG] service_name :1.414, prev_owner :1.414, new_owner 
05-05 01:16:23.031+0900 D/indicator( 2177): indicator_ui.c: _property_changed_cb(1189) > _property_changed_cb[1189]	 "UNSNIFF API 2a00003"
05-05 01:16:23.031+0900 D/indicator( 2177): indicator_ui.c: _active_indicator_handle(1098) > [SECURE_LOG] _active_indicator_handle[1098]	 "Type : 1, opacity 0, active_win 1a00002"
05-05 01:16:23.031+0900 D/indicator( 2177): indicator_util.c: indicator_signal_emit_by_win(144) > [SECURE_LOG] indicator_signal_emit_by_win[144]	 "emission 0 bg.opaque"
05-05 01:16:23.031+0900 D/indicator( 2177): indicator_ui.c: _active_indicator_handle(1104) > [SECURE_LOG] _active_indicator_handle[1104]	 "Type : 2, angle 0, active_win 1a00002"
05-05 01:16:23.031+0900 D/indicator( 2177): indicator_ui.c: _rotate_window(635) > _rotate_window[635]	 "_rotate_window = 0"
05-05 01:16:23.111+0900 W/CRASH_MANAGER(10522): worker.c: worker_job(1189) > 111052168656c143075618
