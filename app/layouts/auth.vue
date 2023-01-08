<script lang="ts" setup>


</script>

<template>
  <div class="flex md:h-screen min-h-full">
    <div class="flex flex-1 flex-col justify-center py-12 px-4 sm:px-6 lg:flex-none lg:px-20 xl:px-24">
      <div class="mx-auto w-full max-w-sm lg:w-96">
        <div>
          <nuxt-link to="/">
            <logo class="h-12 w-auto mx-auto" />
          </nuxt-link>
          <h2 class="mt-6 text-3xl font-bold tracking-tight text-gray-900">Sign in to your account</h2>
        </div>

        <div class="mt-8">

          <div class="mt-6">
            <slot />
          </div>
        </div>
      </div>
    </div>
    <div class="relative hidden w-0 flex-1 lg:block">
      <img class="absolute inset-0 h-full w-full object-cover" src="~/assets/auth/background.png" alt="">
    </div>
  </div>
</template>
