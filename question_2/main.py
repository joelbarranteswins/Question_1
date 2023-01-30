from pathlib import Path
import pytesseract as tess
from PIL import Image
import os


def get_png_file_paths_from_folder(folder_path: Path) -> list:
    files_path = []
    for file in os.listdir(folder_path):
        if file.endswith(".png") or file.endswith(".PNG"):
            files_path.append(Path.joinpath(Path(folder_path), file))
    return files_path


if __name__ == "__main__":
    # get working directory using pathlib
    cwd = Path.cwd()

    # get all files from inputs folder filtered by .png
    file_paths = get_png_file_paths_from_folder(
        Path.joinpath(cwd, "question_2", "inputs"))
    print(file_paths)

    for path in file_paths:
        my_image = Image.open(path)
        osd = tess.image_to_osd(my_image)
        print(osd)
