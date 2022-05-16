#https://www.linuxjournal.com/content/downloading-entire-web-site-wget

wget \
     --recursive \
     --no-clobber \
     --page-requisites \
     --html-extension \
     --convert-links \
     --restrict-file-names=windows \
     --domains docs.spring.io \
     --no-parent \
         docs.spring.io/spring-framework/docs/5.3.x/reference/html/