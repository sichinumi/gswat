$(function(window,$,_){
    _.extend(window, {
        PBF: new pGSWAT()
    });

    PBF.init({
        CDN : CDN,
        main_ele: '#content'
    });

    console.log('Views',PBF.view_definitions);
    console.log('Models',PBF.model_definitions);
    console.log('Collections',PBF.collection_definitions);
    console.log('PBF Object',PBF);
}(window,jQuery,_));