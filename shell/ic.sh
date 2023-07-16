#!/bin/bash
#function batch_convert() {
    for file in *.srt
    do
 #       iconv -f BIG-5 -t UTF-8 "$file" > "sub/_$file" 
#    mv -f "$file.new" "$file"
recode BIG-5..UTF-8 "$file"
    done
#}

#batch_convert ~/Media/sf_share/sub