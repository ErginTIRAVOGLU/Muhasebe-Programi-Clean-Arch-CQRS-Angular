import { Injectable } from '@angular/core';
import * as cryptoJs from "crypto-ts"

@Injectable({
  providedIn: 'root'
})
export class CryptoService {

  constructor() { }

  encrypto(value: string):string{

    return cryptoJs.AES.encrypt(value, 'secret key 123').toString();
  }

  decrypto(value:string):string{


    var bytes  = cryptoJs.AES.decrypt(value, 'secret key 123');
    return bytes.toString(cryptoJs.enc.Utf8);
  }

}
