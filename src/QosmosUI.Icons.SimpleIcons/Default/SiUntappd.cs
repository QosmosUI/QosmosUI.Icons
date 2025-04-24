// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiUntappd : ComponentBase
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
		builder.AddAttribute(15, "d", "M11 13.299l-5.824 8.133c-.298.416-.8.635-1.308.572-.578-.072-1.374-.289-2.195-.879S.392 19.849.139 19.323a1.402 1.402 0 0 1 .122-1.425l5.824-8.133a3.066 3.066 0 0 1 1.062-.927l1.146-.604c.23-.121.436-.283.608-.478.556-.631 2.049-2.284 4.696-4.957l.046-.212a.134.134 0 0 1 .096-.1l.146-.037a.135.135 0 0 0 .101-.141l-.015-.18a.13.13 0 0 1 .125-.142c.176-.005.518.046 1.001.393s.64.656.692.824a.13.13 0 0 1-.095.164l-.175.044a.133.133 0 0 0-.101.141l.012.15a.131.131 0 0 1-.063.123l-.186.112c-1.679 3.369-2.764 5.316-3.183 6.046a2.157 2.157 0 0 0-.257.73l-.205 1.281A3.074 3.074 0 0 1 11 13.3zm12.739 4.598l-5.824-8.133a3.066 3.066 0 0 0-1.062-.927l-1.146-.605a2.138 2.138 0 0 1-.608-.478 50.504 50.504 0 0 0-.587-.654.089.089 0 0 0-.142.018 97.261 97.261 0 0 1-1.745 3.223 1.42 1.42 0 0 0-.171.485 3.518 3.518 0 0 0 0 1.103l.01.064c.075.471.259.918.536 1.305l5.824 8.133c.296.413.79.635 1.294.574a4.759 4.759 0 0 0 2.209-.881 4.762 4.762 0 0 0 1.533-1.802 1.4 1.4 0 0 0-.122-1.425zM8.306 3.366l.175.044a.134.134 0 0 1 .101.141l-.012.15a.13.13 0 0 0 .063.123l.186.112c.311.623.599 1.194.869 1.721.026.051.091.06.129.019.437-.469.964-1.025 1.585-1.668a.137.137 0 0 0 .003-.19c-.315-.322-.645-.659-1.002-1.02l-.046-.212a.13.13 0 0 0-.096-.099l-.146-.037a.135.135 0 0 1-.101-.141l.015-.18a.13.13 0 0 0-.123-.142c-.175-.005-.518.045-1.002.393-.483.347-.64.656-.692.824a.13.13 0 0 0 .095.164z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
