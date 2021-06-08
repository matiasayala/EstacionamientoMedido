//function ScrollLock() {
//    const body = document.body;
//    //const fixedTop = document.querySelector('.fixed-top');
//    //fixedTop.style.right = 'calc(0.15rem + 0.25vh + 0.25vw)';
//    body.style.top = `-${window.scrollY}px`;
//    body.style.position = 'fixed';
//    //body.style.overflowY = 'scroll';
//    //body.style.paddingLeft = 'calc(0.2rem + 0.25vh + 0.25vw)';
//}

//function ScrollUnlock() {
//    const scrollY = document.body.style.top;
//    const body = document.body;
//    //const fixedTop = document.querySelector('.fixed-top');
//    //fixedTop.style.right = '';
//    body.style.position = '';
//    body.style.top = '';
//    //body.style.overflowY = '';
//    //body.style.paddingLeft = '';
//    window.scrollTo(0, parseInt(scrollY || '0') * -1);
//}

function ScrollLock() {
    const body = document.body;
    //const oldWidth = Math.max(body.scrollWidth, body.offsetWidth, body.clientWidth);
    const oldWidth = body.offsetWidth;
    body.style.overflow = 'hidden';
    body.style.width = oldWidth + 'px';
}

function ScrollUnlock() {
    const body = document.body;
    body.style.overflow = '';
    body.style.width = '';
}
