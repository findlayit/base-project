import { RouterConfig } from '@angular/router';
import { SignedInGuard } from './guards/signedIn.guard';

import { Home } from './components/home/home.component';
import { Login } from './components/account/login/login.component';
import { Register } from './components/account/register/register.component';

import { Unauthorised } from './components/errors/unauthorised/unauthorised.component';
import { NoContent } from './no-content';

export const routes: RouterConfig = [
  { path: '', component: Home },

  { path: 'account/login', component: Login },
  { path: 'account/register', component: Register },

  { path: 'unauthorised', component: Unauthorised },
  { path: '**', component: NoContent },
];
