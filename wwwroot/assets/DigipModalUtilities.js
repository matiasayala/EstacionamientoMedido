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
