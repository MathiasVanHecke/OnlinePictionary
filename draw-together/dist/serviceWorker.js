importScripts("/precache-manifest.56719b0ce8b44188ec9d8472ce501ef5.js", "https://storage.googleapis.com/workbox-cdn/releases/3.6.3/workbox-sw.js");

const version = 'v1';

self.addEventListener('install', function (){
    console.log('service worker installed at', new Date().toLocaleTimeString());
    event.waitUntil(
        caches.open(version)
        .then(function (cache) {
            return cache.addAll('/css/*.css');
        })
    );
})

self.addEventListener('activate', function (){
    console.log('service worker activated at', new Date().toLocaleTimeString());
})

self.addEventListener('fetch', function(event){
    if(!navigator.onLine){
        event.respondWith(new Response('<h1>You seem to be offline...</h1>', {headers: {'Content-type' : 'text/html'} }));
    }
    else {
        event.respondWith(fetch(event.request));
    }
}) 
