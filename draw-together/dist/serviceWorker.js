importScripts("/precache-manifest.45fc99f3e8e925bd07b9ca524fdb6123.js", "https://storage.googleapis.com/workbox-cdn/releases/3.6.3/workbox-sw.js");

self.addEventListener('install', function (){
    console.log('service worker installed at', new Date().toLocaleTimeString());
})
