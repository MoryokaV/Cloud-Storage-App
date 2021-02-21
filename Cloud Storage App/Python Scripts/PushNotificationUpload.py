#!/usr/bin/env python3

from win10toast import ToastNotifier

toaster = ToastNotifier()
toaster.show_toast("Cloud Storage App","The file was uploaded successfully!",icon_path = "gdrive.ico",duration = 8)
