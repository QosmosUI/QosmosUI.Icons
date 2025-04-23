// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Devicons;

public class DiChrome : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "32";

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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M20.206 16.286c0 2.323-1.883 4.206-4.206 4.206s-4.206-1.883-4.206-4.206c0-2.323 1.883-4.206 4.206-4.206s4.206 1.883 4.206 4.206zM15.975 11.274v-0h10.164c-1.848-3.731-5.694-6.296-10.139-6.296-3.599 0-6.804 1.681-8.876 4.301l3.878 6.631c0.192-2.584 2.343-4.622 4.973-4.635zM16 21.297c-2.169 0-4.016-1.378-4.714-3.306l-4.68-8.004c-1.209 1.8-1.915 3.966-1.915 6.297 0 5.692 4.206 10.401 9.679 11.191l3.901-6.723c-0.682 0.348-1.454 0.544-2.272 0.544zM26.5 12.080h-7.773c1.376 0.893 2.285 2.443 2.285 4.206 0 0.867-0.22 1.682-0.607 2.393l0.003 0.002-5.158 8.888c0.248 0.016 0.498 0.025 0.751 0.025 6.245 0 11.308-5.063 11.308-11.308 0-1.486-0.287-2.906-0.809-4.206z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
