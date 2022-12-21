// https://nuxt.com/docs/api/configuration/nuxt-config
export default defineNuxtConfig({
    css: ['~/assets/css/main.css'],

    components: {
        dirs: [
        '~/components',
        ]
    },
    
    postcss: {
        plugins: {
          tailwindcss: {},
          autoprefixer: {},
        },
      },

    pages: true
})

