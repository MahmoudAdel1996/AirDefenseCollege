import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthenticationService } from 'src/app/Services/authentication.service';

@Component({
  selector: 'app-storage-main',
  templateUrl: './storage-main.component.html',
  styleUrls: ['./storage-main.component.scss']
})
export class StorageMainComponent implements OnInit {

  constructor(private authenticationService: AuthenticationService,private route: ActivatedRoute,
    private router: Router) { }

  ngOnInit(): void {
  }
  logout(){
    this.authenticationService.logout();
    location.reload(true);
    this.router.navigate(['/']);
  }
}
