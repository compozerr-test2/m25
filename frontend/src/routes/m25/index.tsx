import React from "react"
import { createFileRoute } from '@tanstack/react-router'
import M25Component from '../../m25-component'

export const Route = createFileRoute('/m25/')({
  component: RouteComponent,
})

function RouteComponent() {
  return (
    <div>
      <M25Component name="World!" />
    </div>
  )
}
