// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiPrimefaces : ComponentBase
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
		builder.AddAttribute(15, "d", "M6.43 0 3.875 2.564l3.833.367L8.988 0Zm3.104 0L8.081 3.465 1.5 2.931l1.094 4.58 7.853 2.931h1.095V0Zm2.74 0v10.442h1.278l7.853-2.93 1.095-4.58-6.756.547L14.283 0Zm2.556 0 1.28 2.931 3.834-.367L17.387 0ZM2.778 8.244v6.229l4.383 3.663v-5.68l1.278-1.83-1.643.366-2.009-2.016zm18.261 0-2.009.732-2.009 2.016-1.643-.367 1.278 1.832v5.68l4.383-3.664zM9.17 10.625l-1.462 2.199v8.243l1.097 1.65L10.083 24h3.652l1.278-1.284 1.096-1.649v-8.243l-1.46-2.199-.914.55h-3.652zm-4.383 6.23v2.38l2.374 2.382V18.87zm14.243 0-2.374 2.015v2.747l2.374-2.381z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
