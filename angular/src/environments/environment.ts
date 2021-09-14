import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'AbpGestionClient',
    logoUrl: '',
    
  },
  oAuthConfig: {
    issuer: 'https://localhost:44354',
    redirectUri: baseUrl,
    clientId: 'AbpGestionClient_App',
    responseType: 'code',
    scope: 'offline_access openid profile role email phone AbpGestionClient',
  },
  apis: {
    default: {
      url: 'https://localhost:44354',
      rootNamespace: 'Acme.AbpGestionClient',
    },
  },
} as Environment;
