// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Logo;

public class BiLogoBxlMastodon : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M16 17.24c2.5-.3 4.69-1.84 5-3.25a33.59 33.59 0 0 0 .4-5.42C21.33 4.23 18.48 3 18.48 3A17.64 17.64 0 0 0 12 2a17.64 17.64 0 0 0-6.48 1S2.68 4.23 2.68 8.57v3.44c.1 4.24.78 8.42 4.7 9.46A14.73 14.73 0 0 0 12 22a9.21 9.21 0 0 0 3.54-.81l-.07-1.64A11.41 11.41 0 0 1 12 20c-1.8-.06-3.71-.19-4-2.4a4.26 4.26 0 0 1 0-.63 22.68 22.68 0 0 0 4 .54 23.6 23.6 0 0 0 4-.27zm-6.54-9.8q-1.35 0-1.35 1.62v5.1H6V8.9a3.78 3.78 0 0 1 .82-2.56 2.85 2.85 0 0 1 2.23-1 2.68 2.68 0 0 1 2.4 1.23l.52.87.52-.87a2.68 2.68 0 0 1 2.4-1.23 2.85 2.85 0 0 1 2.23 1A3.78 3.78 0 0 1 18 8.9v5.26h-2.11v-5.1q0-1.62-1.35-1.62c-1 0-1.51.64-1.51 1.92v2.79H11V9.36c0-1.28-.54-1.92-1.54-1.92z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
