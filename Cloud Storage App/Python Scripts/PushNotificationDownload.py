#!/usr/bin/env python3

from win10toast import ToastNotifier

toaster = ToastNotifier()
toaster.show_toast("Cloud Manager App","The file was downloaded successfully!",icon_path = "gdrive.ico",duration = 8)
