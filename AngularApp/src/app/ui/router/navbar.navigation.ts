import { AuthService } from "../components/auth/service/auth.service";


export class Navigation2 {
constructor(private _authService:AuthService){}
}
export class Navigation
  {

    routerLink?: string="";
    name: string="";
    icon: string="";



  }

  export const Navigations: Navigation[] = [
    {
      routerLink:"/",
      name:"Ana Sayfa",
      icon:"fa fa-home"
    },
    {
      routerLink:"/ucafs",
      name:"Hesap Planı",
      icon:"fa fa-file-signature"
    }

  ]


