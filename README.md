# XamarinFormsAds

## Requisitos

1. Crease una cuenta en [Goolge Admob](https://apps.admob.com/v2/home)
    1.1 Crear una aplicacion (Android o iOS)
    1.2 Seleccionar **Configuración de Aplicación** y copiar el **ID de la aplicación** (i.e.) ca-app-pub-xxxxxxxxxxxxxxxx~xxxxxxxxxx
    1.3 Seleccionar **Bloque de Anuncios**, agregar un **Banner** y copiar el **ID del bloque de anuncios** ca-app-pub-xxxxxxxxxxxxxxxx/xxxxxxxxxx

## Android

1. Permisos requeridos
    1.1 **ACCESS_NETWORK_STATE**
    1.2 **INTERNET**
2. Nuget **Xamarin.GooglePlayServices.Ads.Lite** -Version **71.1720.1**
3. Inicializar las ads en el **MainActivity** **MobileAds.Initialize(ApplicationContext, "appId")**
4. ID del bloque de Anuncio para probar mientar activar el de producción **ca-app-pub-3940256099942544/6300978111**

## iOS

1. Nuget **Xamarin.Google.iOS.MobileAds** -Version **7.38.0**
2. Inicializar las ads en el **MainActivity** **AppDelegate.Configure("appId")**
3. ID del bloque de Anuncio para probar mientar activar el de producción **ca-app-pub-3940256099942544/2934735716**
