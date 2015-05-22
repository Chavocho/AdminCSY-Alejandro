// Variables globales
    var map, geocoder;
    // Instancia del geocodificador
    geocoder = new google.maps.Geocoder();
    // Propiedades iniciales del mapa
    window.onload = function() {
        var options = {
            zoom: 15,
            center: new google.maps.LatLng(20.6281556, -103.252946399),
            mapTypeId: google.maps.MapTypeId.ROADMAP
        };
        // Instancia del mapa
        map = new google.maps.Map(document.getElementById('map'), options);
            // Obtiene la ubicación (string) a georreferenciar
            var location = "@onta_el_cliete@";
            // Inicia el proceso de georreferenciación (asíncrono)
            processGeocoding(location, addMarkers);
    }
    function processGeocoding(location, callback)
    {
        // Propiedades de la georreferenciación        
        var request = {
            address: location
        }        
        // Invocación a la georreferenciación (proceso asíncrono)        
        geocoder.geocode(request, function(results, status) {
            // En caso de terminarse exitosamente el proyecto ...
            if(status == google.maps.GeocoderStatus.OK)
            {
                // Invoca la función de callback
                callback (results);
                // Retorna los resultados obtenidos
                return results;
            }
            // En caso de error retorna el estado
            return status;
        });
    }
    function addMarkers(geocodes)
    {
        for(i=0; i<geocodes.length; i++)
        {
            // Centra el mapa en la nueva ubicación            
            map.setCenter(geocodes[i].geometry.location);
            // Valores iniciales del marcador
            var marker = new google.maps.Marker({
                map: map,
                title: geocodes[i].formatted_address
				//aqui podemos agregar el icono con la info del cliente
				// y quitar el evento "google.maps.event.addListener(marker, 'click', function(event) {..." de la info del cliente
            });            
            // Establece la ubicación del marcador
            marker.setPosition(geocodes[i].geometry.location);            
            // Establece el contenido de la ventana de información            
            var infoWindow = new google.maps.InfoWindow();

            content = "Cliente: Pal' que pidio torta <br />" +
							"Ubicación: " + geocodes[i].formatted_address + "<br />" +
                             "Tipo: " + geocodes[i].types + "<br />" +
                             "Latitud: " + geocodes[i].geometry.location.lat() + "<br />" +
                             "Longitud: " + geocodes[i].geometry.location.lng();
            
            infoWindow.setContent(content);
            // Asocia el evento de clic sobre el marcador con el despliegue
            // de la ventana de información
			// para mi restaurant podemos quitar este evento
            google.maps.event.addListener(marker, 'click', function(event) {				
                infoWindow.open(map, marker);
            });
        }
    }