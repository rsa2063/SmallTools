#https://stackoverflow.com/questions/1224766/how-do-i-rename-the-extension-for-a-bunch-of-files

find . -name '*.js' -exec sh -c 'mv "$0" "${0%.js}.jsx"' {} \;



