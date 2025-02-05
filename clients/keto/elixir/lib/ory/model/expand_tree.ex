# NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
# https://openapi-generator.tech
# Do not edit the class manually.

defmodule Ory.Model.ExpandTree do
  @moduledoc """
  
  """

  @derive [Poison.Encoder]
  defstruct [
    :children,
    :subject_id,
    :subject_set,
    :type
  ]

  @type t :: %__MODULE__{
    :children => [Ory.Model.ExpandTree.t] | nil,
    :subject_id => String.t | nil,
    :subject_set => Ory.Model.SubjectSet.t | nil,
    :type => String.t
  }
end

defimpl Poison.Decoder, for: Ory.Model.ExpandTree do
  import Ory.Deserializer
  def decode(value, options) do
    value
    |> deserialize(:children, :list, Ory.Model.ExpandTree, options)
    |> deserialize(:subject_set, :struct, Ory.Model.SubjectSet, options)
  end
end

