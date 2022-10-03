import Vue from 'vue'
import Router from 'vue-router'

Vue.use(Router)

export default new Router({
  mode: 'history',
  base: process.env.BASE_URL,
  routes: [
    {
          path: '/',
          name: 'home',
          // route level code-splitting
          // this generates a separate chunk (home.[hash].js) for this route
          // which is lazy-loaded when the route is visited.
          component: () => import(/* webpackChunkName: "home" */ '../views/HomeView.vue')
        },
        {
          path: '/about',
          name: 'about',
          // route level code-splitting
          // this generates a separate chunk (about.[hash].js) for this route
          // which is lazy-loaded when the route is visited.
          component: () => import(/* webpackChunkName: "about" */ '../views/AboutView.vue')
        },
        {
          path: '/contact-us',
          name: 'contact-us',
          // route level code-splitting
          // this generates a separate chunk (contact-us.[hash].js) for this route
          // which is lazy-loaded when the route is visited.
          component: () => import(/* webpackChunkName: "contact-us" */ '../views/ContactView.vue')
        },
        {
          path: '/profile',
          name: 'profile',
          // route level code-splitting
          // this generates a separate chunk (profile.[hash].js) for this route
          // which is lazy-loaded when the route is visited.
          component: () => import(/* webpackChunkName: "profile" */ '../views/ProfileView.vue')
        },
        {
          path: '/register',
          name: 'register',
          // route level code-splitting
          // this generates a separate chunk (register.[hash].js) for this route
          // which is lazy-loaded when the route is visited.
          component: () => import(/* webpackChunkName: "register" */ '../views/RegisterView.vue')
        },
        {
          path: '/login',
          name: 'login',
          // route level code-splitting
          // this generates a separate chunk (login.[hash].js) for this route
          // which is lazy-loaded when the route is visited.
          component: () => import(/* webpackChunkName: "login" */ '../views/LoginView.vue')
        },
  ]
})