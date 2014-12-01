﻿/*SHA-256 Implementacion en JavaScript*/

/*Variables de encripción*/
'use strict';
var Sha256 = {};
/* Generar hash SHA-256 de string's
 * @param   {string} msg - String debe de estar hashed
 * @returns {string} Hash de msg como cadena de caracteres hexadecimales*/
Sha256.hash = function (msg) {
    //Convertir la serie en UTF-8, como SHA sólo se ocupa de byte-corrientes
    msg = msg.utf8Encode();
    // Constantes 
    var K = [
        0x428a2f98, 0x71374491, 0xb5c0fbcf, 0xe9b5dba5, 0x3956c25b, 0x59f111f1, 0x923f82a4, 0xab1c5ed5,
        0xd807aa98, 0x12835b01, 0x243185be, 0x550c7dc3, 0x72be5d74, 0x80deb1fe, 0x9bdc06a7, 0xc19bf174,
        0xe49b69c1, 0xefbe4786, 0x0fc19dc6, 0x240ca1cc, 0x2de92c6f, 0x4a7484aa, 0x5cb0a9dc, 0x76f988da,
        0x983e5152, 0xa831c66d, 0xb00327c8, 0xbf597fc7, 0xc6e00bf3, 0xd5a79147, 0x06ca6351, 0x14292967,
        0x27b70a85, 0x2e1b2138, 0x4d2c6dfc, 0x53380d13, 0x650a7354, 0x766a0abb, 0x81c2c92e, 0x92722c85,
        0xa2bfe8a1, 0xa81a664b, 0xc24b8b70, 0xc76c51a3, 0xd192e819, 0xd6990624, 0xf40e3585, 0x106aa070,
        0x19a4c116, 0x1e376c08, 0x2748774c, 0x34b0bcb5, 0x391c0cb3, 0x4ed8aa4a, 0x5b9cca4f, 0x682e6ff3,
        0x748f82ee, 0x78a5636f, 0x84c87814, 0x8cc70208, 0x90befffa, 0xa4506ceb, 0xbef9a3f7, 0xc67178f2];
    // Valor Inicial del Hash 
    var H = [
        0x6a09e667, 0xbb67ae85, 0x3c6ef372, 0xa54ff53a, 0x510e527f, 0x9b05688c, 0x1f83d9ab, 0x5be0cd19];
    //Antes del Proceso
    msg += String.fromCharCode(0x80);  // Añadir barra "1" bit (+ de 0 relleno) para valor inicial del hash

    //Convertir msg en bloques de 512-bit / 16-enteros arrEGLOS de enteros 
    var l = msg.length / 4 + 2; //Longitud (en enteros de 32 bits) de msg + '1' de longitud + anexa
    var N = Math.ceil(l / 16);  //Número de 16 enteros necesarios para mantener ints 'l'
    var M = new Array(N);

    for (var i = 0; i < N; i++) {
        M[i] = new Array(16);
        for (var j = 0; j < 16; j++) {  //Codificar 4 caracteres por entero, codificación big-endian 
            M[i][j] = (msg.charCodeAt(i * 64 + j * 4) << 24) | (msg.charCodeAt(i * 64 + j * 4 + 1) << 16) | (msg.charCodeAt(i * 64 + j * 4 + 2) << 8) | (msg.charCodeAt(i * 64 + j * 4 + 3));
        }
    }
    //Agregar longitud (en bits) en último par de enteros de 32 bits (big-endian)
    //Nota: la palabra más significativa sería (LEN-1) * 8 >>> 32, pero desde conversos JS
    //Bit a bit-op args a 32 bits, tenemos que simular esto por operadores aritméticos
    M[N - 1][14] = ((msg.length - 1) * 8) / Math.pow(2, 32); M[N - 1][14] = Math.floor(M[N - 1][14]);
    M[N - 1][15] = ((msg.length - 1) * 8) & 0xffffffff;
    // HASH COMPILACIÓN
    var W = new Array(64); var a, b, c, d, e, f, g, h;
    for (var i = 0; i < N; i++) {
        //1.-Preparar el mensaje 'W'
        for (var t = 0; t < 16; t++) W[t] = M[i][t];
        for (var t = 16; t < 64; t++) W[t] = (Sha256.σ1(W[t - 2]) + W[t - 7] + Sha256.σ0(W[t - 15]) + W[t - 16]) & 0xffffffff;

        //2.-Inicializar las variables de trabajo a, b, c, d, e, f, g, h con el valor de hash anterior
        a = H[0]; b = H[1]; c = H[2]; d = H[3]; e = H[4]; f = H[5]; g = H[6]; h = H[7];

        //3.-Bucle principal (nota: 'adición módulo 2 ^ 32')
        for (var t = 0; t < 64; t++) {
            var T1 = h + Sha256.Σ1(e) + Sha256.Ch(e, f, g) + K[t] + W[t];
            var T2 = Sha256.Σ0(a) + Sha256.Maj(a, b, c);
            h = g;
            g = f;
            f = e;
            e = (d + T1) & 0xffffffff;
            d = c;
            c = b;
            b = a;
            a = (T1 + T2) & 0xffffffff;
        }
        //4.- Calcular el nuevo valor hash intermedio (nota: 'adición módulo 2 ^ 32')
        H[0] = (H[0] + a) & 0xffffffff;
        H[1] = (H[1] + b) & 0xffffffff;
        H[2] = (H[2] + c) & 0xffffffff;
        H[3] = (H[3] + d) & 0xffffffff;
        H[4] = (H[4] + e) & 0xffffffff;
        H[5] = (H[5] + f) & 0xffffffff;
        H[6] = (H[6] + g) & 0xffffffff;
        H[7] = (H[7] + h) & 0xffffffff;
    }
    return Sha256.toHexStr(H[0]) + Sha256.toHexStr(H[1]) + Sha256.toHexStr(H[2]) + Sha256.toHexStr(H[3]) +
           Sha256.toHexStr(H[4]) + Sha256.toHexStr(H[5]) + Sha256.toHexStr(H[6]) + Sha256.toHexStr(H[7]);
};

/*Gira a la derecha (circular desplazamiento a la derecha) valor x por n posiciones*/
Sha256.ROTR = function (n, x) {
    return (x >>> n) | (x << (32 - n));
};

/**
 * Funciones Logicas
 * @private
 */
Sha256.Σ0 = function (x) { return Sha256.ROTR(2, x) ^ Sha256.ROTR(13, x) ^ Sha256.ROTR(22, x); };
Sha256.Σ1 = function (x) { return Sha256.ROTR(6, x) ^ Sha256.ROTR(11, x) ^ Sha256.ROTR(25, x); };
Sha256.σ0 = function (x) { return Sha256.ROTR(7, x) ^ Sha256.ROTR(18, x) ^ (x >>> 3); };
Sha256.σ1 = function (x) { return Sha256.ROTR(17, x) ^ Sha256.ROTR(19, x) ^ (x >>> 10); };
Sha256.Ch = function (x, y, z) { return (x & y) ^ (~x & z); };
Sha256.Maj = function (x, y, z) { return (x & y) ^ (x & z) ^ (y & z); };


/*Representación hexadecimal de un número*/
Sha256.toHexStr = function (n) {
    //Nota: no puede utilizar toString (16), ya que es dependiente de la implementación, y en IE(Internet Explorer) vuelve firmaron los números cuando se utiliza en palabras llenas
    var s = "", v;
    for (var i = 7; i >= 0; i--) { v = (n >>> (i * 4)) & 0xf; s += v.toString(16); }
    return s;
};


/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  */
/** Extender objeto String con el método para codificar la cadena multi-byte a UTF8
 *  - monsur.hossa.in/2012/07/20/utf-8-in-javascript.html */
if (typeof String.prototype.utf8Encode == 'undefined') {
    String.prototype.utf8Encode = function () {
        return unescape(encodeURIComponent(this));
    };
}
/** Extender objeto String con el método para decodificar cadena utf8 para multi-byte */
if (typeof String.prototype.utf8Decode == 'undefined') {
    String.prototype.utf8Decode = function () {
        try {
            return decodeURIComponent(escape(this));
        } catch (e) {
            return this; //UTF-8 NVALID? de regreso si lo es-
        }
    };
}


/* - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  */
if (typeof module != 'undefined' && module.exports) module.exports = Sha256; //Exportacion común en JS
if (typeof define == 'function' && define.amd) define([], function () { return Sha256; }); // AMD

