<script lang="ts" setup>
import { ref } from 'vue';

definePageMeta({
  layout: "auth",
});

const request = ref({
  email: '',
  password: ''
});
</script>

<template>
  <form action="#" method="POST" class="space-y-6">
    <div>
      <label for="email" class="block text-sm font-medium text-gray-700">Email address</label>
      <div class="mt-1">
        <input id="email" name="email" type="email" autocomplete="email" required v-model="request.email"
          class="block w-full appearance-none rounded-md border border-gray-300 px-3 py-2 placeholder-gray-400 shadow-sm focus:border-indigo-500 focus:outline-none focus:ring-indigo-500 sm:text-sm">
      </div>
    </div>

    <div class="space-y-1">
      <label for="password" class="block text-sm font-medium text-gray-700">Password</label>
      <div class="mt-1">
        <ui-input-field auto-complete="current-password" name="password" v-model="request.password" type="password" />
      </div>
    </div>

    <div class="flex items-center justify-between">
      <div class="flex items-center">
        <input id="remember-me" name="remember-me" type="checkbox"
          class="h-4 w-4 rounded border-gray-300 text-indigo-600 focus:ring-indigo-500">
        <label for="remember-me" class="ml-2 block text-sm text-gray-900">Remember me</label>
      </div>

      <div class="text-sm">
        <a href="#" class="font-medium text-gray-600 hover:text-gray-500">Forgot your password?</a>
      </div>
    </div>

    <div>
      <ui-button title="Sign in" />
    </div>
  </form>
</template>
