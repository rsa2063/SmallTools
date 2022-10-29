// http://www.ruanyifeng.com/blog/2011/06/a_guide_for_writing_bookmarklet.html
if (!window.jQuery) {

    script = document.createElement('script');

    script.src = 'https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.1/jquery.min.js';

    script.onload = foo;

    document.body.appendChild(script);

} else {
    foo();
}

function foo() {
 alert($('a')[0].innerHTML);
}