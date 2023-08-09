import"./esm-chunk-d81494b9.js";import{ensureElement as t,findParentBySelector as e,calculateStyles as i,addClassNameToElement as s,removeClassNameFromElement as n,RequestAnimationFrame as r,setStylesCore as o,subscribeElementContentSize as a,unsubscribeElement as l,pxToInt as h,getCurrentStyle as u,elementHasCssClass as d}from"./esm-dom-utils-88a2c0cb.js";import{d as c}from"./esm-chunk-fc46b9cc.js";import"./esm-chunk-639f7231.js";import{initFocusHidingEvents as m}from"./esm-focus-utils-eb2e3d52.js";import{S as p}from"./esm-chunk-4bcd729b.js";class g{constructor(t,e){if(!e)throw new Error("Collection should be able to create item");this.items=[],this.itemCreateFunc=e,this.subscriptions=[],this.isLocked=!1,this.isCollection=!0,this.subjectsCache={},t&&this.addRange(t)}subscribe(t){this.isLocked||t(this.getChanges(this.items)),this.subscriptions.push(t)}getChanges(t,e){return{addedItems:t||[],removedItems:e||[]}}forEach(t){this.items.forEach(t)}selectMany(t){return this.map(t).reduce((function(t,e){return t.concat(e.items||e)}),[])}reduce(t,e){return this.items.reduce(t)}map(t){return this.items.map(t)}filter(t){return this.items.filter(t)}any(){return this.count()>0}count(){return this.items.length}countAsSubject(){return this.getMethodAsSubject(this.count)}withSorting(t){return new window.Components.SortedCollection(this,t)}withGrouping(t){return new window.Components.GroupedCollection(this,t)}withFilter(t){return new window.Components.FilteredCollection(this,t)}withMapping(t){return new window.Components.MappedCollection(this,t)}anyAsSubject(t){return t?this.withFilter(t).anyAsSubject():this.getMethodAsSubject(this.any)}getMethodAsSubject(t){if(!this.subjectsCache[t]){const e=t.bind(this),i=this.subjectsCache[t]=new window.Components.Subject(e());this.subscribe((function(){i.setValue(e())}))}return this.subjectsCache[t]}get(t){return this.items[t]}add(t){this.addItemCore(t)&&this.raiseChanges([t],[])}remove(t){this.removeItemCore(t)&&this.raiseChanges([],[t])}addRange(t){this.raiseChanges(t.map(this.addItemCore.bind(this)).filter((function(t){return!!t})),[])}removeRange(t){this.raiseChanges([],t.map(this.removeItemCore.bind(this)).filter((function(t){return!!t})))}addItemCore(t){return this.items.indexOf(t)>-1?null:this.items[this.items.length]=t}removeItemCore(t){const e=this.items.indexOf(t);return-1===e?null:this.items.splice(e,1)}raiseChanges(t,e){const i=this.getChanges(t,e);(i.addedItems.length>0||i.removedItems.length>0)&&this.subscriptions.forEach((function(t){t(i)}))}serialize(){const t=Array(this.items.length);let e=!1;const i=window.getIndexSequence(this.items.length-1);return e=window.serialize(this.items,t,i)||e,e?t:void 0}update(t){const e=t.length<this.items.length?this.items.splice(t.length):[],i=window.getIndexSequence(Math.max(-1,t.length-this.items.length-1)).map(function(e){const i=e+this.items.length;return this.itemCreateFunc(i,t[i])}.bind(this));this.items=this.items.concat(i),window.deserialize(t,this.items,window.getIndexSequence(this.items.length-1)),this.raiseChanges(i,e)}lock(){this.isLocked=!0}unlock(){this.isLocked=!1}}class b{constructor(t,e,i){this.block=e,this.layer=t,this.width=0,i.subscribe(e,function(t,i){null===t&&(t=this.layer.getPrevLayer().getActualBlocks().filter((function(t){return t.block===e}))[0].width),t!==this.width&&(this.width=t,i||this.layer.requestUpdateLayoutModel())}.bind(this))}getMinWidth(){return this.width}getMaxWidth(){return this.getMinWidth()}}class f extends b{getMaxWidth(t){return t===this.layer?this.layer.getPrevLayer().getActualBlocks().filter(function(t){return t.block===this.block}.bind(this))[0].getMinWidth():this.getMinWidth()}}class y extends b{}class I extends b{}class x{constructor(t,e){this.widthCalculator=t,this.triggersResolver=e}subscribe(t,e){const s=this.widthCalculator.bind(this);this.triggersResolver(t).forEach((function(n){n.subscribe((function(){t.isWidthCalculationLocked||i((function(){e(s(t))}))}),!0)})),i((function(){e(s(t),!0)}))}}const w={fullWidthItem:new x((function(t){return t.getWidth()}),D),fullWidthSystemItem:new x((function(t){return t.getWidth()}),(function(t){return[]})),titleItem:new x((function(t){return t.getWidth()}),(function(t){return[t.toolbar.title.HasTitle,t.toolbar.title.Text]})),noTextItem:new x((function(t){return t.getNoTextWidth()}),D),contextItem:function(t){return new x((function(e){return t.items.filter((function(t){return"item"===t.getName()&&t.index<e.index&&t.isVisible()})).length>=e.toolbar.MinRootItems||!e.isVisible()?0:null}),D)},hiddenItem:new x((function(){return 0}),(function(){return[]}))};class C{constructor(t,e,i,s){this.stateName=t,this.nextLayer=null,this.prevLayer=i,i&&(i.nextLayer=this),this.layoutBlocks=[],this.blockUpdaterGetter=e,this.latestRange=null,this.canApply=s}getNextLayer(){return null!=this.nextLayer?this.nextLayer.canApply()?this.nextLayer:this.nextLayer.getNextLayer():null}getPrevLayer(){return null!=this.prevLayer?this.prevLayer.canApply()?this.prevLayer:this.prevLayer.getPrevLayer():null}requestUpdateLayoutModel(){this.getPrevLayer().requestUpdateLayoutModel()}isValidWidth(t){if(!this.canApply())return!1;const e=this.getRange();return!this.getNextLayer()&&e.min>t||!this.getPrevLayer()&&e.max<t||e.min<=t&&e.max>=t}getRange(){return this.latestRange=this.getActualBlocks().reduce(function(t,e){return{min:t.min+e.getMinWidth(),max:t.max+e.getMaxWidth(this)}}.bind(this),{min:0,max:0})}getActualBlocks(){return this.getPrevLayer()?this.getPrevLayer().getActualBlocks().map(function(t){return this.layoutBlocks.filter((function(e){return e.block===t.block}))[0]||t}.bind(this)):this.layoutBlocks}activate(t){this.layoutBlocks.forEach(function(t){t.block.updateStateCore(this.stateName)}.bind(this))}addBlock(t){const e=this.blockUpdaterGetter(t);e&&this.layoutBlocks.push(this.createBlock(t,e))}removeBlock(t){}createBlock(t,e){}}class k extends C{constructor(t,e,i,s){super(t,e,null,s),this.layoutModel=i}requestUpdateLayoutModel(){this.layoutModel.updateLayout()}createBlock(t,e){return new I(this,t,e)}}class L extends C{activate(t){const e=this.getActualBlocks();let i=this.latestRange.max,s=this.stateName;for(let n=e.length-1;n>=0;n--){const r=e[n];if(i>t){if(i-=r.getMaxWidth(this)-r.getMinWidth(),i<=t){r.block.updateStateCore(s),s=this.getPrevLayer().stateName;continue}}r.block.updateStateCore(s)}}getRange(){return this.latestRange=this.getActualBlocks().reduce(function(t,e){return{min:t.min+e.getMinWidth(),max:t.max+e.getMaxWidth(this)}}.bind(this),{min:0,max:0})}createBlock(t,e){return new f(this,t,e)}}class v extends C{createBlock(t,e){return new y(this,t,e)}getRange(){return this.latestRange={min:this.getActualBlocks().reduce((function(t,e){return t+e.getMinWidth()}),0),max:this.getPrevLayer().getRange().max-1}}}class M{constructor(t){this.layers=[],this.currentWidth=null,this.onLayerApplied=t}initialize(t,e,i){this.elementContentWidthSubscription=a(e,e=>{this.currentWidth===e.width&&this.currentHeight===e.height||(null===this.currentWidth&&t.subscribe(function(t){t.addedItems.forEach(this.addBlock.bind(this)),t.removedItems.forEach(this.removeBlock.bind(this))}.bind(this)),this.currentWidth=e.width,this.currentHeight=e.height,i&&i(e))})}dispose(){this.elementContentWidthSubscription&&l(this.elementContentWidthSubscription)}getLastLayer(){return this.layers[this.layers.length-1]||null}defaultLayer(t,e){this.layers.push(new k("default",t,this,e))}simultaneousTransitionLayer(t,e,i){this.layers.push(new v(t,e,this.getLastLayer(),i))}sequentialTransitionLayer(t,e,i){this.layers.push(new L(t,e,this.getLastLayer(),i))}addBlock(t){this.layers.forEach((function(e){e.addBlock(t)}))}removeBlock(t){this.layers.forEach((function(e){e.removeBlock(t)}))}updateLayout(){const t=this.findLayersForWidth(this.currentWidth);t.length>0&&this.applyLayer(t[0])}resetToDefault(){this.applyLayer(this.layers[0])}applyLayer(t){t.activate(this.currentWidth),this.onLayerApplied&&this.onLayerApplied(t)}findLayersForWidth(t){return this.layers.filter((function(e){return e.isValidWidth(t)}))}forceUpdate(){null!==this.currentWidth&&this.updateLayout()}}class S extends class{constructor(){this.state=null,this.isWidthCalculationLocked=!1}updateStateCore(t){this.state=t,this.updateState(t)}updateState(t){}getElement(){}getGlobalRefreshTrigger(){}}{constructor(t,e){super(),this.element=e,this.toolbar=t}getWidth(){return this.isVisible()?G(this.getElement()):0}isVisible(){return!0}getName(){}getElement(){return this.element}getGlobalRefreshTrigger(){return this.toolbar.RefreshTrigger}}class W extends S{constructor(t,e){super(t),this.item=e,this.index=-1}getElement(){return this.item.getElement()}updateState(t){this.item.IsDisplayed.update(t.indexOf("has-"+this.getName())>-1)}}class R extends W{constructor(t,e){super(t,e)}getNoTextWidth(){return this.item.IsDisplayed.value?function(t){let e=G(t);if(t){const i=t.querySelector(".image");if(i){e-=z(i);let t=i;for(;t=t.nextElementSibling;)d(t,"popout")||"absolute"===u(t).position||(e-=G(t))}}return e}(this.getElement()):0}getName(){return"item"}isVisible(){return this.item.IsDisplayed.value}updateState(t){const e=this.item.toolbar;this.updateVisible(e.MinRootItems>0?-1===t.indexOf("has-ellipsis")||this.index<e.MinRootItems:-1===t.indexOf("has-ellipsis")&&-1===t.indexOf("has-sidemenu"))}updateVisible(t){t||(this.isWidthCalculationLocked=!0),this.item.updateVisible(t),t&&(this.isWidthCalculationLocked=!1)}}class T extends W{constructor(t,e){super(t,e)}getName(){return"ellipsis"}updateState(t){W.prototype.updateState.call(this,t),this.updateVisible(this.item.IsDisplayed.value)}updateVisible(t){t||(this.isWidthCalculationLocked=!0),this.item.updateVisible(t),t&&(this.isWidthCalculationLocked=!1)}}class A extends R{constructor(t,e){super(t,e),this.itemBlocks=[],this.addItem(e)}addItem(t){this.itemBlocks.push(new R(this.toolbar,t))}isVisible(){return this.itemBlocks.reduce((function(t,e){return t&&e.isVisible()}),!0)}getWidth(){return this.itemBlocks.reduce((function(t,e){return t+e.getWidth()}),0)}getNoTextWidth(){return this.itemBlocks.reduce((function(t,e){return t+e.getNoTextWidth()}),0)}updateVisible(t){this.itemBlocks.forEach((function(e){e.updateVisible(t)}))}tryAddItem(t){const e=this.itemBlocks[this.itemBlocks.length-1].item;let i=!1;return(i=e.GroupName===t.GroupName&&e.group===t.group&&e.AdaptivePriority.value===t.AdaptivePriority.value)&&this.addItem(t),i}}class E extends S{constructor(t,e,i){super(t,e),this.item=i}getName(){return"title"}getWidth(){return G(this.getElement(),!0)}getElement(){return this.item.getElement()}}class B{constructor(t,e){this.element=t,this.toolbar=e,this.isVisible=!0,this.IsVisible=new p(null),this.IsVisible.subscribe(function(t){this.onIsVisibleChanged(t)}.bind(this),!0)}getElement(){return this.element}updateVisible(t){this.IsVisible.update(t)}onIsVisibleChanged(t){const e=this.getElement();e&&(t?this.show(e):this.hide(e))}show(t){t.classList.remove("ta-hidden-item")}hide(t){t.classList.add("ta-hidden-item")}}class N extends B{constructor(t,e,i){super(t,i),this.group=e,this.IsDisplayed=new p(!0),this.Text=new p,this.GroupName=new p,this.AdaptivePriority=new p,this.Index=new p,this.IconCssClass=new p}onIsVisibleChanged(t){super.onIsVisibleChanged(t),this.group.onItemVisibleChanged()}getElement(){return document.querySelector(U("data-dxtoolbar-item-id",this.Id))}getParent(){const t=this.getElement();if(t&&t.parentNode)return t.parentNode}show(t){o(t,"display",""),this.jsHelper.invokeMethodAsync("Show")}hide(t){o(t,"display","none"),this.jsHelper.invokeMethodAsync("Hide")}}class V extends B{constructor(t,e){super(t,e),this.items=[]}addItem(t){this.items.push(t)}onItemVisibleChanged(){if(0===this.items.length)return;const t=this.items.some(t=>t.IsVisible.value);this.updateVisible(t)}getElement(){if(0===this.items.length)return null;const t=e(this.items[0].getElement(),U("data-dxtoolbar-group-id",this.toolbar.id));return t||this.items[0].getParent()}}class j{constructor(t){this.element=t,this._refreshTrigger=new p(!1),this.itemMap=new Map,this.groupMap=new Map,this.items=[]}setEllipses(t){this.ellipses=t}get RefreshTrigger(){return this._refreshTrigger.asTrigger(t=>!t)}refresh(){this._refreshTrigger.update(this.refreshTrigger.value)}}class H extends B{constructor(t,e){super(t,e),this.toolbar=e,this.element=t,this.IsDisplayed=new p(!0),this.Text=new p}show(t){o(t,"display",""),this.jsHelper.invokeMethodAsync("Show")}hide(t){o(t,"display","none"),this.jsHelper.invokeMethodAsync("Hide")}}class P extends B{constructor(t,e,i){super(t,e),this.toolbar=e,this.HasTitle=new p,this.Text=new p,this.Text.subscribe(function(t){this.HasTitle.update(null!=t&&""!==t)}.bind(this)),this.elementSelector=i}getElement(){return document.querySelector(this.elementSelector)}}class q{constructor(){this.IsLoading=!0}init(t,r,o){this.isLayoutCalculated=!1;const a=o,l=t.dataset.dxtoolbarId,h=U("data-dxtoolbar-title-id",l),u=U("data-dxtoolbar-ellipses-id",l),d=document.querySelector(u),c=this.toolbar=new j(t),m=c.groupMap;c.id=l,Array.from(r.items).forEach((t,i)=>{const s=document.querySelector(U("data-dxtoolbar-item-id",t.id)),n=e(s,U("data-dxtoolbar-group-id",l));let r=null;m.has(n)?r=m.get(n):(r=new V(n,c),m.set(n,r));const o=new N(s,r,c);o.jsHelper=t.jsHelper,o.Text.update(t.text),o.GroupName.update(t.groupName),o.AdaptivePriority.update(t.adaptivePriority),o.IconCssClass.update(t.iconCssClass),o.IsDisplayed.update(t.visible),o.Index.update(t.index),o.Id=t.id,c.itemMap.set(o.Id,o),c.items.some(t=>t.Index.value===o.Index.value)||(r.addItem(o),c.items.push(o))}),c.setEllipses(d),c.CanHideRootItems=r.canHideRootItems,c.CanCollapseToIcons=r.canCollapseToIcons,c.MinRootItems=r.minRootItems,c.ItemSize=r.itemSize,c.RenderMode=r.renderMode;const p=new g([],t=>{});c.title=new P(c.title,c,h),p.add(new E(c,c.title,c.title)),p.addRange(this.getItemsBlocks(c,new g(Array.from(m.values()),(function(){}))));const b=new H(c.ellipses,c);b.jsHelper=r.adaptiveMenuModel.jsHelper,p.add(new T(c,b));const f=w.contextItem(p),y=this.Model=new M(function(e){if(!this.isLayoutCalculated){this.isLayoutCalculated=!0;const t=c.element;i(function(){const e=t.querySelector(".btn-toolbar");this.updateControlStyles(c,Math.ceil(!this.IsLoading&&e?e.offsetHeight:t.offsetHeight)),this.IsLoading=!1}.bind(this))}const r=c.element.querySelector(".btn-toolbar")||c.element;e.stateName.indexOf("no-item-text")>-1?s(r,"no-item-text"):n(r,"no-item-text"),n(t,"dxbs-loading"),a.invokeMethodAsync("OnModelUpdated")}.bind(this));y.defaultLayer((function(t){switch(t.getName()){case"item":return w.fullWidthItem;case"title":return w.titleItem}return w.hiddenItem}),()=>!0),y.sequentialTransitionLayer("has-ellipsis",(function(t){switch(t.getName()){case"ellipsis":return w.fullWidthSystemItem;case"item":return f}}),()=>c.CanHideRootItems&&c.MinRootItems>0),y.simultaneousTransitionLayer("no-item-text",(function(t){switch(t.getName()){case"item":return w.noTextItem;case"ellipsis":return w.hiddenItem}}),()=>c.CanCollapseToIcons),y.sequentialTransitionLayer(c.CanCollapseToIcons?"no-item-text has-ellipsis":"has-ellipsis",(function(t){switch(t.getName()){case"item":return f;case"ellipsis":return w.fullWidthSystemItem}}),()=>c.CanHideRootItems),y.initialize(p,c.element.querySelector(".btn-toolbar")||c.element,function(t){this.height!==t.height&&(this.isLayoutCalculated=!1,this.height=t.height),this.layoutModel.updateLayout()}.bind(this)),this.layoutModel=y}reinit(t,e){this.reinitRequested||(this.reinitRequested=!0,r(function(){this.resetToDefault(),this.disposeModel(),r(function(){this.reinitRequested=!1,this.init(t.mainElement,t,e)}.bind(this))}.bind(this)))}resetToDefault(){this.layoutModel.resetToDefault()}update(t,e){let i=!1,s=!1;this.toolbar.CanHideRootItems!==t.canHideRootItems&&(this.toolbar.CanHideRootItems=t.canHideRootItems,i=!0),this.toolbar.CanCollapseToIcons!==t.canCollapseToIcons&&(this.toolbar.CanCollapseToIcons=t.canCollapseToIcons,i=!0),this.toolbar.MinRootItems!==t.minRootItems&&(this.toolbar.MinRootItems=t.minRootItems,i=!0),this.toolbar.ItemSize!==t.itemSize&&(this.toolbar.ItemSize=t.itemSize,s=!0),this.toolbar.RenderMode!==t.renderMode&&(this.toolbar.RenderMode=t.renderMode,s=!0),this.toolbar.title.Text.update(t.title);const n=Array.from(t.items).map(t=>t.id),r=Array.from(this.toolbar.itemMap.values()).map(t=>t.Id);var o,a;if(s=s||!((o=n).length===(a=r).length&&o.every((t,e)=>t===a[e])),s)return this.reinit(t,e),void 0;Array.from(t.items).forEach((t,e)=>{const i=this.toolbar.itemMap.get(t.id);i&&(i.Text.update(t.text),i.GroupName.update(t.groupName),i.AdaptivePriority.update(t.adaptivePriority),i.Index.update(t.index),i.IconCssClass.update(t.iconCssClass),i.IsDisplayed.update(t.visible),i.jsHelper=t.jsHelper)}),i&&this.layoutModel.forceUpdate()}disposeModel(){this.layoutModel&&this.layoutModel.dispose()}dispose(){this.disposeModel()}getItemsBlocks(t,e){return e.selectMany((function(t){return t.items})).reduce(function(e,i){return e.group&&e.group.tryAddItem(i)?e:i.GroupName?{group:e.blocks[e.blocks.length]=new A(t,i),blocks:e.blocks}:{group:null,blocks:e.blocks.concat([new R(t,i)])}}.bind(this),{blocks:[],group:null}).blocks.sort((function(t,e){return t.item.AdaptivePriority.value-e.item.AdaptivePriority.value})).map((function(t,e){return t.index=e,t}))}updateControlStyles(t,e){o(t.element,"height",e+"px")}}function D(t){return[t.item.Text,t.item.IsDisplayed,t.item.IconCssClass]}function G(t,e){let i=t?Math.ceil(t.offsetWidth+(e?0:z(t))):0;if(t){if(t.parentElement.lastElementChild===t){const e=u(t.parentElement);i+=h(e.marginRight)}if(t.parentElement.firstElementChild===t){const e=u(t.parentElement);i+=h(e.marginLeft)}}return i}function z(t){return function(t,e){const i=e||u(t);return h(i.marginLeft)+h(i.marginRight)}(t)}function U(t,e){return`[${t}=${e}]`}const O=new Map;function F(e,i,s){const n=t(e);if(null===n)return;c(n);let r=O.get(n);r?r.update(i,s):(r=new q,r.init(n,i,s),O.set(n,r));const o=n.querySelector(".btn-toolbar")||n;return m(o),Promise.resolve("ok")}function _(e){if(e=t(e)){c(e);const t=O.get(e);t&&(t.dispose(),O.delete(e))}return Promise.resolve("ok")}const $={init:F,dispose:_};export default $;export{_ as dispose,F as init};
