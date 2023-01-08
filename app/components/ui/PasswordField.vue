<script lang="ts" setup>
import { Ref } from 'vue';

const type: Ref<'password' | 'text'> = ref('password');

const props = defineProps({
    modelValue: {
        type: String,
        required: true,
    },
    name: {
        type: String,
        required: true,
    },
    id: {
        type: String,
        required: false,
    },
    placeholder: {
        type: String,
        required: false,
        default: '',
    }
});

const emit = defineEmits({
    'update:modelValue': (_modelValue: string) => true,
});

const input: Ref<string> = ref(props.modelValue);

watch(input, (newValue: string) => {
    emit('update:modelValue', newValue);
});
</script>

<template>
    <input :id="props.id ?? props.name" :name="props.name" :type="type" required v-model="input"
        :placeholder="props.placeholder"
        class="block w-full appearance-none rounded-md border border-gray-300 px-3 py-2 placeholder-gray-400 shadow-sm focus:border-indigo-500 focus:outline-none focus:ring-indigo-500 sm:text-sm"
        spellcheck="false">
</template>