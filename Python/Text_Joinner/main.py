import os

def isCorrectDir(path):
    if os.path.isdir(path):
        print("This path is correct!")
    else:
        print("This path is incorrect!")


def main():
    files = []
    texts = []
    path = input("Please input directory path!")
    if not os.path.isdir(path):
        print("This path is incorrect!")
    else:
        for x in os.listdir(path):
            if os.path.isfile(path + "\\" + x) and x[-4:] == ".txt":
                files.append(x)
        print(files)
        for f in files:
            with open(path + "\\" + f) as text:
                # print(text.read())
                texts.append(text.read())
        with open(path + "\\joined.txt", mode='w') as f:
            # f.write("\n\n".join(texts))
            i = 0
            for t in texts:
                f.write("\n\n【 " + files[i][:-4] + " 】" + "\n\n" + t)
                i += 1


if __name__ == "__main__":
    main()
