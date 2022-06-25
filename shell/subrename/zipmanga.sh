for dir in */; do ( cd "$dir" && zip -r ../"${dir%/}".zip . ) done
