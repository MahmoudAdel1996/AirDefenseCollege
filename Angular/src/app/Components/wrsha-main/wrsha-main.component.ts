import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthenticationService } from 'src/app/Services/authentication.service';


@Component({
  selector: 'app-wrsha-main',
  templateUrl: './wrsha-main.component.html',
  styleUrls: ['./wrsha-main.component.scss']
})
export class WrshaMainComponent implements OnInit{
  constructor(private authenticationService: AuthenticationService,private route: ActivatedRoute,
    private router: Router) {}
  ngOnInit() {
  }
  logout(){
    this.authenticationService.logout();
    location.reload(true);
    this.router.navigate(['/']);
  }
}