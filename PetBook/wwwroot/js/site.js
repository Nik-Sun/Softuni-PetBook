// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
import { Loader } from '../lib/googlemaps/js-api-loader/dist/index.esm.js';



let apiKey = window.apiKey

let loader = new Loader({
    apiKey: apiKey,
    version: "beta",
    libraries: ["places", "marker","drawing"]
})





export { loader }







