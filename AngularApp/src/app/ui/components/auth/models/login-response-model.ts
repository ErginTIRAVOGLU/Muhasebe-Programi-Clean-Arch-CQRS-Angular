import { CompanyModel } from "./company-model";
import { TokenModel } from "./token-modek";

export class LoginResponseModel{
  token:TokenModel=new TokenModel();
  email:string="";
  userId:string="";
  name:string="";
  surname:string="";
  companies:CompanyModel[] = [];
  company:CompanyModel=new CompanyModel();
  year:number = new Date().getFullYear();
}
