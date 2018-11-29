importScripts("/precache-manifest.bf574f2706f29added430d43560cb671.js", "https://storage.googleapis.com/workbox-cdn/releases/3.6.3/workbox-sw.js");

self.addEventListener('install', function (){
    console.log('service worker installed at', new Date().toLocaleTimeString());
})

self.addEventListener('activate', function (){
    console.log('service worker activated at', new Date().toLocaleTimeString());
})

self.addEventListener('fetch', function(event){
    if(!navigator.onLine){
        event.respondWith(new Response('<h1>You seem to be offline...</h1>'))
    }
    else {
        event.respondWith(fetch(event.request));
    }
})
