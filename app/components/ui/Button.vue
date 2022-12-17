<script lang="ts" setup>
import { PropType } from 'vue';

const emit = defineEmits([
    'click',
]);

const props = defineProps({
    title: {
        type: String,
        required: true,
    },
    classes: {
        type: Array as PropType<string[]>,
        required: false,
        default: () => ([
            'focus:ring-gray-500',
            'hover:bg-gray-700',
            'bg-gray-600',
        ])
    }
});

</script>

<template>
    <button type="submit"
        class="flex w-full justify-center rounded-md border border-transparent py-2 px-4 text-sm font-medium text-white shadow-sm focus:outline-none focus:ring-2 focus:ring-offset-2"
        :class="props.classes">
        {{ props.title }}
    </button>
</template>
