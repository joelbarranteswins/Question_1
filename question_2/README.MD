# Text orientation detection in images

## Pytesseract
    
* [pytesseract link from pypi](https://pypi.org/project/pytesseract/)

* [GitHub - madmaze/pytesseract: A Python wrapper for Google Tesseract](https://github.com/madmaze/pytesseract)

The following instructions should be considered to ensure that pytesseract works correctly in both scripts and the shell:

* [Installation tesseract](https://tesseract-ocr.github.io/tessdoc/Installation.html)

Important: install the Tesseract binary and add its path to the system environment variables

* [How to install binary tesseract](https://github.com/UB-Mannheim/tesseract/wiki)

Conclusion:

* The library reads text horizontally, regardless of whether the input, the image, is horizontal or vertical.
* There is a process within the library called OSD (Orientation and Script Detection) that generates Rotate: 0 if it is horizontal and Rotate: 90 if it is vertical.


