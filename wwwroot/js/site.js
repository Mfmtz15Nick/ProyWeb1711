// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




var camiones = new Vue({
    el: '#camiones',
    data: {
        message: 'Vue.js',
        camiones: 'holis',
        camionesPost: 'Paps',
    },
    // define methods under the `methods` object
    methods: {
        greet: function (event) {
            axios
                .get('https://localhost:5001/api/Camiones/')
                .then(response => (this.camiones = response.data))

        },
        greetPost: function (event) {
            axios.post('https://localhost:5001/api/Camiones', {
                tipoCamion: "GDE",
                tipoCombustible: "BioDiesel",
                placas: 1,
                capacidadPeso: 1000,
                volumen: 1000,
                Kilometraje: 500,
                KilometrajeUltimoServicio: 1
            }).then(response => {
                (this.camionesPost = response.data)
            }).catch(e => {
                console.log(e);
            });
        },
        greetPut: function (event) {
            axios.put('https://localhost:5001/api/Camiones/2009', {
                id:2009,
                tipoCamion: "GDE",
                tipoCombustible: "BioGas",
                placas: 111,
                capacidadPeso: 111,
                volumen: 111,
                Kilometraje: 111,
                KilometrajeUltimoServicio: 111
            }).then(response => {
                (this.camionesPost = response.data)
                // Respuesta del servidor
            }).catch(e => {
                console.log(e);
            });
        },
        greetDelete: function (event) {
            axios.delete('https://localhost:5001/api/Camiones/2009', {                
            }).then(response => {
                (this.camionesPost = response.data)
                // Respuesta del servidor
            }).catch(e => {
                console.log(e);
            });
        }





    }
})
