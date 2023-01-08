<script lang="ts" setup>
definePageMeta({
  layout: "auth",
});

const request = ref({
  email: '',
  password: ''
});

const submit = async () => {
  alert('hello')
}

</script>

<template>
  <form action="#" method="POST" class="space-y-6" @submit.prevent="submit">
    <div>
      <ui-form-field placeholder="Email" name="email" v-model="request.email" auto-complete="current-email" />
    </div>

    <div class="space-y-1">
      <ui-form-field placeholder="Password" name="password" v-model="request.password"
        auto-complete="current-password" />
    </div>

    <div class="flex items-center justify-between">
      <div class="flex items-center">
        <input id="remember-me" name="remember-me" type="checkbox"
          class="h-4 w-4 rounded border-gray-300 text-indigo-600 focus:ring-indigo-500">
        <label for="remember-me" class="ml-2 block text-sm text-gray-900">Remember me</label>
      </div>

      <div class="text-sm">
        <nuxt-link to="/auth/forgot" class="font-medium text-gray-600 hover:text-gray-500">Forgot your
          password?</nuxt-link>
      </div>
    </div>

    <div>
      <ui-button title="Sign in" />
    </div>
  </form>
</template>
