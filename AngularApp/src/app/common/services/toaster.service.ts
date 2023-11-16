import { Injectable } from '@angular/core';
declare const $:any;
declare const toastr:any;

@Injectable({
  providedIn: 'root'
})
export class ToasterService {

  constructor() { }

  toast(type:ToasterType, message:string, title: string){
    switch (type) {
      case ToasterType.Success:
        toastr.success(title,message) ;
        break;
      case ToasterType.Info:
        toastr.info(title,message) ;
        break;
      case ToasterType.Error:
        toastr.error(title,message) ;
        break;
      case ToasterType.Warning:
        toastr.warning(title,message) ;
        break;

      default:
        break;
    }


  }
}

export enum ToasterType{
  Success,
  Error,
  Info,
  Warning
}
