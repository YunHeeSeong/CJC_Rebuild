import"./esm-chunk-d81494b9.js";import{ensureElement as t,attachEventToElement as e,detachEventFromElement as n}from"./esm-dom-utils-88a2c0cb.js";import{d as i,r as o}from"./esm-chunk-fc46b9cc.js";function s(t,e,n){t.style.position="absolute",t.style.visibility="hidden",t.style.display="block";const i=function(t,e,n){const i=(d=t,d.offsetParent),o=function(t){if(!t)return{X:0,Y:0};const e=t.getBoundingClientRect();return{X:e.left+0,Y:e.top+0}}(i),s=i.getBoundingClientRect(),c=t.getBoundingClientRect();var d;let l=e+0-o.X;s.left+l+c.width>=document.body.clientWidth&&(l=document.body.clientWidth-c.width-s.left-1);l+=i.scrollLeft;let u=n+0-o.Y;s.top+u+c.height>=window.innerHeight&&(u-=c.height+1);return u+=i.scrollTop,{X:l,Y:u}}(t,e,n);return t.style.top=i.Y+"px",t.style.left=i.X+"px",t.style.visibility="visible",!1}function c(t){t.style.display="none",u(t)}function d(t){t.invokeMethodAsync("Hide")}function l(c,l,u,r){if(!(c=t(c)))return;i(c);const f=function(t){return function(t,e,n){const i=document.getElementById(e);i.contains(t.target)||i===t.target||d(n)}(t,c.id,r)},h=function(t){return function(t,e){"Escape"===t.key&&d(e)}(t,r)};return"ontouchstart"in window?e(document,"touchstart",f):e(document,"mousedown",f),e(document,"keydown",h),o(c,(function(){"ontouchstart"in window?n(document,"touchstart",f):n(document,"mousedown",f),n(document,"keydown",h)})),s(c,l,u),Promise.resolve("ok")}function u(e){if(e=t(e))return i(e),Promise.resolve("ok")}function r(e,n){if(!(n=t(n)))return;n.style.visibility="hidden",n.style.display="block";const i=e.getBoundingClientRect(),o=n.getBoundingClientRect();n.style.position="absolute";let s=e.offsetTop;i.top+o.height>=window.innerHeight&&(s-=o.height+i.top+1-window.innerHeight),n.style.top=s+"px";let c=i.width;i.left+c+o.width>=document.body.clientWidth&&(c-=o.width+i.width+1),n.style.left=c+"px",n.style.visibility="visible"}const f={renderMenu:l,dispose:u,renderSubMenu:r,hideMenuClientSide:c};export default f;export{u as dispose,c as hideMenuClientSide,l as renderMenu,r as renderSubMenu};
