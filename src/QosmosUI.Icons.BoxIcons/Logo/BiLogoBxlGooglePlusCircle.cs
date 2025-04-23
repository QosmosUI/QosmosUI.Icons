// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.BoxIcons.Logo;

public class BiLogoBxlGooglePlusCircle : ComponentBase
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
		builder.AddAttribute(14, "d", "M22.014 11.974C21.996 6.462 17.521 2 12.008 2 6.493 2 2.019 6.462 2.001 11.974L2 11.948v.112l.001-.023c.017 5.513 4.491 9.977 10.007 9.977 5.514 0 9.988-4.462 10.006-9.974l.001.026v-.118l-.001.026zM9.281 16.557c-2.509 0-4.548-2.039-4.548-4.549s2.039-4.549 4.548-4.549c1.23 0 2.258.451 3.046 1.188l-1.295 1.255c-.325-.309-.899-.673-1.751-.673-1.505 0-2.733 1.251-2.733 2.785 0 1.533 1.229 2.784 2.733 2.784 1.742 0 2.384-1.206 2.502-1.92H9.279V11.18h4.255c.066.286.115.554.115.932 0 2.597-1.742 4.445-4.368 4.445zm10.458-4.095H17.92v1.819h-1.364v-1.819h-1.82v-1.364h1.82v-1.82h1.364v1.82h1.819v1.364z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
