import { HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ToasterService, ToasterType } from './toaster.service';

@Injectable({
  providedIn: 'root'
})
export class ErrorService {

  constructor(
    private _toastr: ToasterService
  ) { }
    errorHandler(err:HttpErrorResponse){

    switch (err.status) {
      case 0:
        this._toastr.toast(ToasterType.Error,"Hata!","Api adresine ulaşılamıyor!");
        break;
      case 404:
        this._toastr.toast(ToasterType.Error,"Hata!","Api adresi bulunamıyor!");
        break;
      case 500:
        if(err.error.Errors)
        {
          let erros:any =err.error.Errors;
          erros.forEach((element:any) => {
            this._toastr.toast(ToasterType.Error,"Hata!",element);
          });
        }
        else{
          this._toastr.toast(ToasterType.Error,"Hata!",err.error.Message);
        }
        break;
      default:
        console.log(err);
        break;
    }



  console.log(err);
}

}
