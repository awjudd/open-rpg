<script lang="ts" setup>

const sideBarClosed = ref(false);

const yearSpan = computed(() => {
  const current = new Date();

  if (current.getFullYear() > 2023) {
    return `2023 - ${current.getFullYear()}`;
  }

  return '2023';
});
</script>

<template>
  <div class="relative bg-gray-50 overflow-hidden">
    <div :class="{
      hidden: sideBarClosed
    }" class="hidden sm:block sm:absolute sm:inset-y-0 sm:h-full sm:w-full">
      <div class="relative h-full max-w-screen-xl mx-auto">
        <svg class="absolute right-full transform translate-y-1/4 translate-x-1/4 lg:translate-x-1/2" width="404"
          height="784" fill="none" viewBox="0 0 404 784">
          <defs>
            <pattern id="f210dbf6-a58d-4871-961e-36d5016a0f49" x="0" y="0" width="20" height="20"
              patternUnits="userSpaceOnUse">
              <rect class="text-gray-200" x="0" y="0" width="4" height="4" fill="currentColor"></rect>
            </pattern>
          </defs>
          <rect width="404" height="784" fill="url(#f210dbf6-a58d-4871-961e-36d5016a0f49)"></rect>
        </svg>
        <svg
          class="absolute left-full transform -translate-y-3/4 -translate-x-1/4 md:-translate-y-1/2 lg:-translate-x-1/2"
          width="404" height="784" fill="none" viewBox="0 0 404 784">
          <defs>
            <pattern id="5d0dd344-b041-4d26-bec4-8d33ea57ec9b" x="0" y="0" width="20" height="20"
              patternUnits="userSpaceOnUse">
              <rect class="text-gray-200" x="0" y="0" width="4" height="4" fill="currentColor"></rect>
            </pattern>
          </defs>
          <rect width="404" height="784" fill="url(#5d0dd344-b041-4d26-bec4-8d33ea57ec9b)"></rect>
        </svg>
      </div>
    </div>
    <div class="relative pt-6 pb-12 sm:pb-16 md:pb-20 lg:pb-28 xl:pb-32">
      <div class="max-w-screen-xl mx-auto px-4 sm:px-6">
        <nav class="relative flex items-center justify-between sm:h-10 md:justify-center">
          <div class="flex items-center flex-1 md:absolute md:inset-y-0 md:left-0">
            <div class="flex items-center justify-between w-full md:w-auto">
              <a href="#" aria-label="Home">
                <logo class="pl-5 h-8 w-auto sm:h-10" alt="" />
              </a>
              <div class="-mr-2 flex items-center md:hidden">
                <button
                  class="inline-flex items-center justify-center p-2 rounded-md text-gray-400 hover:text-gray-500 hover:bg-gray-100 focus:outline-none focus:bg-gray-100 focus:text-gray-500 transition duration-150 ease-in-out"
                  id="main-menu" type="button" aria-label="Main menu" aria-haspopup="true"
                  @click="sideBarClosed = !sideBarClosed">
                  <svg class="h-6 w-6" stroke="currentColor" fill="none" viewBox="0 0 24 24">
                    <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M4 6h16M4 12h16M4 18h16">
                    </path>
                  </svg>
                </button>
              </div>
            </div>
          </div>
          <div :class="{
            hidden: !sideBarClosed
          }" class="hidden md:flex md:space-x-10"></div>
          <div :class="{
            hidden: !sideBarClosed
          }" class="hidden md:absolute md:flex md:items-center md:justify-end md:inset-y-0 md:right-0">
            <span class="inline-flex rounded-md shadow"><nuxt-link
                class="inline-flex items-center px-4 py-2 border border-transparent text-base leading-6 font-medium rounded-md text-indigo-600 bg-white hover:text-indigo-500 focus:outline-none focus:border-indigo-300 focus:shadow-outline-indigo active:bg-gray-50 active:text-indigo-700 transition duration-150 ease-in-out"
                to="/auth/register">Register</nuxt-link></span>
            <span class="inline-flex rounded-md shadow"><nuxt-link
                class="inline-flex items-center px-4 py-2 border border-transparent text-base leading-6 font-medium rounded-md text-indigo-600 bg-white hover:text-indigo-500 focus:outline-none focus:border-indigo-300 focus:shadow-outline-indigo active:bg-gray-50 active:text-indigo-700 transition duration-150 ease-in-out"
                to="/auth/login">Log in</nuxt-link></span>
          </div>
        </nav>
      </div>
      <div :class="{
        hidden: !sideBarClosed
      }" class="absolute top-0 inset-x-0 p-2 transition transform origin-top-right">
        <div class="rounded-lg shadow-md">
          <div class="rounded-lg bg-white shadow-xs overflow-hidden" role="menu" aria-orientation="vertical"
            aria-labelledby="main-menu">
            <div class="px-5 pt-4 flex items-center justify-between">
              <div>
                <logo class="h-8 w-auto" alt="" />
              </div>
              <div class="-mr-2">
                <button @click="sideBarClosed = !sideBarClosed"
                  class="inline-flex items-center justify-center p-2 rounded-md text-gray-400 hover:text-gray-500 hover:bg-gray-100 focus:outline-none focus:bg-gray-100 focus:text-gray-500 transition duration-150 ease-in-out"
                  type="button" aria-label="Close menu">
                  <svg class="h-6 w-6" stroke="currentColor" fill="none" viewBox="0 0 24 24">
                    <path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M6 18L18 6M6 6l12 12">
                    </path>
                  </svg>
                </button>
              </div>
            </div>

            <div>
              <nuxt-link
                class="block w-full px-5 py-3 text-center font-medium text-indigo-600 bg-gray-50 hover:bg-gray-100 hover:text-indigo-700 focus:outline-none focus:bg-gray-100 focus:text-indigo-700 transition duration-150 ease-in-out"
                href="/auth/register" role="menuitem">Register</nuxt-link>
              <nuxt-link
                class="block w-full px-5 py-3 text-center font-medium text-indigo-600 bg-gray-50 hover:bg-gray-100 hover:text-indigo-700 focus:outline-none focus:bg-gray-100 focus:text-indigo-700 transition duration-150 ease-in-out"
                to="/auth/login" role="menuitem">Log in</nuxt-link>
            </div>
          </div>
        </div>
      </div>
      <main class="mt-10 mx-auto max-w-screen-xl px-4 sm:mt-12 sm:px-6 md:mt-16 lg:mt-20 xl:mt-28">
        <div class="text-center">
          <h2
            class="text-4xl tracking-tight leading-10 font-extrabold text-gray-900 sm:text-5xl sm:leading-none md:text-6xl">
            <span class="mr-1">Choose your Species.</span>
            <br class="xl:hidden">
            <span class="text-indigo-600"> Dominate the World.</span>
          </h2>
          <p class="mt-3 max-w-md mx-auto text-base text-gray-500 sm:text-lg md:mt-5 md:text-xl md:max-w-3xl">
            The game is simple ... choose a species and a class and fight of hordes of baddies to dominate the world.
          </p>
          <div class="mt-5 max-w-md mx-auto sm:flex sm:justify-center md:mt-8">
            <div class="rounded-md shadow"><nuxt-link
                class="w-full flex items-center justify-center px-8 py-3 border border-transparent text-base leading-6 font-medium rounded-md text-white bg-indigo-600 hover:bg-indigo-500 focus:outline-none focus:border-indigo-700 focus:shadow-outline-indigo transition duration-150 ease-in-out md:py-4 md:text-lg md:px-10"
                to="/auth/register">Start your Adventure!</nuxt-link></div>
          </div>
        </div>
      </main>
    </div>
  </div>
  <div class="bg-white">
    <div class="max-w-screen-xl mx-auto py-12 px-4 sm:px-6 md:flex md:items-center md:justify-between lg:px-8">
      <div class="flex justify-center md:order-2">
        <a class="ml-6 text-gray-400 hover:text-gray-500" href="https://github.com/awjudd/open-rpg" target="_blank">
          <span class="sr-only">GitHub</span>
          <svg class="h-6 w-6" fill="currentColor" viewBox="0 0 24 24">
            <path fill-rule="evenodd"
              d="M12 2C6.477 2 2 6.484 2 12.017c0 4.425 2.865 8.18 6.839 9.504.5.092.682-.217.682-.483 0-.237-.008-.868-.013-1.703-2.782.605-3.369-1.343-3.369-1.343-.454-1.158-1.11-1.466-1.11-1.466-.908-.62.069-.608.069-.608 1.003.07 1.531 1.032 1.531 1.032.892 1.53 2.341 1.088 2.91.832.092-.647.35-1.088.636-1.338-2.22-.253-4.555-1.113-4.555-4.951 0-1.093.39-1.988 1.029-2.688-.103-.253-.446-1.272.098-2.65 0 0 .84-.27 2.75 1.026A9.564 9.564 0 0112 6.844c.85.004 1.705.115 2.504.337 1.909-1.296 2.747-1.027 2.747-1.027.546 1.379.202 2.398.1 2.651.64.7 1.028 1.595 1.028 2.688 0 3.848-2.339 4.695-4.566 4.943.359.309.678.92.678 1.855 0 1.338-.012 2.419-.012 2.747 0 .268.18.58.688.482A10.019 10.019 0 0022 12.017C22 6.484 17.522 2 12 2z"
              clip-rule="evenodd"></path>
          </svg>
        </a>
      </div>
      <div class="mt-8 md:mt-0 md:order-1">
        <p class="text-center text-base leading-6 text-gray-400">© {{ yearSpan }} Open RPG.
        </p>
      </div>
    </div>
  </div>
</template>