// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiRescript : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

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
		builder.OpenElement(13, "title");
		builder.CloseElement();
		builder.OpenElement(14, "path");
		builder.AddAttribute(15, "d", "M23.29 1.8c-.3-.4-.6-.7-.9-.9-1.3-.9-2.899-.9-6.098-.9H7.696C4.498 0 2.9 0 1.8.8c-.4.3-.7.6-1 1C0 2.9 0 4.5 0 7.7v8.6c0 3.2 0 4.8.8 5.9.3.4.6.7.9.9 1.199.9 2.798.9 5.996.9h8.596c3.199 0 4.798 0 5.898-.8.4-.3.7-.6.9-.9.799-1.1.799-2.7.799-5.9V7.7c.2-3.2.2-4.8-.6-5.9ZM11.194 16.5c0 .2 0 .5-.1.8 0 .2-.1.3-.1.5-.1.1-.2.3-.4.5s-.4.3-.6.4c-.3.1-.7.1-1.399.1-.8 0-1.1 0-1.4-.1-.4-.2-.699-.5-.899-.9-.1-.3-.1-.7-.1-1.4v-8c0-.9 0-1.4.2-1.7.2-.3.4-.5.8-.7.3-.2.8-.2 1.699-.2h2.299zm5.097-4.9c-1.599 0-2.798-1.3-2.798-2.8 0-1.6 1.3-2.8 2.798-2.8 1.5 0 2.8 1.3 2.8 2.8 0 1.5-1.3 2.8-2.8 2.8z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
