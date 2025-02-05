# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.UiText do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :context,
    :id,
    :text,
    :type
  ]

  @type t :: %__MODULE__{
    :context => map() | nil,
    :id => integer(),
    :text => String.t,
    :type => String.t
  }
end

defimpl Poison.Decoder, for: Ory.Model.UiText do
  def decode(value, _options) do
    value
  end
end

