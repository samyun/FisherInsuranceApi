import { Component } from '@angular/core';
import { AuthService } from "../../auth.service";
import { Router } from '@angular/router'; 

@Component({
    selector: 'nav-bar',
    templateUrl: './app/components/navbar/navbar.component.html',
    styleUrls: ['./app/components/navbar/navbar.component.css']
})
export class NavBarComponent { 
    constructor(public router: Router, public authService: AuthService) { }

    isActive(data: any[]) {

    }

    
}