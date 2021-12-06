import { HttpInterceptor, HttpRequest, HttpHandler, HttpEvent } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { AuthenticationService } from "../Services/authentication.service";

@Injectable()
export class BasicAuthInterceptor implements HttpInterceptor {
    constructor(private authenticationService: AuthenticationService) { }

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        // add authorization header with basic auth credentials if available
        const currentUser = this.authenticationService.currentUserValue;
        if (currentUser && currentUser.authdata) {
            request = request.clone({
                setHeaders: { 
                    Authorization: `Basic ${currentUser.authdata}`
                }
            });
        }

        return next.handle(request);
    }
}