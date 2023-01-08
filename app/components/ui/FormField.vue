<script lang="ts" setup>
const props = defineProps({
    autoComplete: {
        type: String,
        required: false,
        default: ''
    },
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
    type: {
        type: String,
        required: false,
        default: 'text',
    },
    placeholder: {
        type: String,
        required: false,
        default: '',
    }
});
</script>

<template>
    <label :for="props.name" class="block text-sm font-medium text-gray-700">{{ props.placeholder }}</label>
    <div class="mt-1">
        <ui-password-field v-if="props.type === 'password'" v-model="props.modelValue" :placeholder="props.placeholder"
            :id="props.id" :name="props.name" :auto-complete="props.autoComplete" />
        <ui-input-field v-else v-model="props.modelValue" :placeholder="props.placeholder" :id="props.id"
            :name="props.name" :auto-complete="props.autoComplete" />

    </div>
</template>