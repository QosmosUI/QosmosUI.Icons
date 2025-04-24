// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiTicket : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 24 24";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "g");
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M21.485 8.071l-5.364-5.364c-1.128-1.128-3.111-1.136-4.248-.018l-9.148 9.002c-.571.562-.887 1.313-.891 2.115-.003.803.307 1.556.873 2.121l5.365 5.365c.567.567 1.325.88 2.133.88.799 0 1.551-.307 2.115-.862l9.147-9.003c.571-.562.888-1.313.891-2.115.003-.802-.307-1.555-.873-2.121zm-1.421 2.811l-9.146 9.003c-.381.373-1.056.37-1.432-.006l-1.275-1.275c.71-.785.693-1.994-.062-2.752-.758-.757-1.968-.773-2.752-.063l-1.275-1.274c-.186-.187-.288-.435-.287-.699s.105-.513.293-.697l9.148-9.002c.189-.186.441-.288.713-.288.273 0 .529.104.719.294l1.275 1.275c-.711.785-.694 1.994.062 2.751.758.757 1.967.773 2.752.063l1.274 1.274c.187.187.288.435.287.699s-.105.512-.294.697zM11.601 17.042l-4.657-4.656 5.649-5.429 4.657 4.656-5.649 5.429zm-3.23-4.643l3.243 3.242 4.206-4.041-3.241-3.242-4.208 4.041z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
