// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiGooglecampaignmanager360 : ComponentBase
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
		builder.AddAttribute(15, "d", "M15.8203 0c-2.093.0002-4.1858.7997-5.7832 2.3965-1.3364 1.3364-2.112 3.0208-2.33 4.7617a8.731 8.731 0 0 1 .4726-.0137c1.7849-.0001 3.5658.5466 5.0763 1.6387-.2066-.8822.0681-1.8261.7127-2.4707 1.046-1.0459 2.7113-.9977 3.7149.0059 1.0827 1.0826 2.8372 1.0826 3.92 0 1.0826-1.084 1.0826-2.8392 0-3.922C20.006.7992 17.9133-.0001 15.8202 0Zm7.0781 4.0781c.0785.929-.234 1.8855-.9414 2.5938-.9808.9809-2.438 1.2037-3.6386.6738.3115.9383.065 1.9896-.6329 2.6875-.9913.9913-2.6633 1.0662-3.7255.0039-.0173-.0172-.0293-.0352-.046-.0527l-.003.002c-3.1988-3.142-8.3393-3.1251-11.5165.0507-3.1935 3.1935-3.1935 8.373 0 11.5664 1.1618 1.1618 3.0453 1.1618 4.207 0 1.1618-1.1618.8689-2.7562-.293-3.918-.9353-.9354-1.1225-2.5928-.0058-3.7109.9095-.9095 2.5376-1.1696 3.7266-.0078.0726.0726.1477.1405.2246.2031 3.208 2.9849 8.2258 2.9155 11.3496-.207 2.68-2.679 3.1113-6.7548 1.295-9.8848zM10.7246 15.1992c.2151.8774-.0348 1.8317-.7012 2.498-.6718.672-1.6786.924-2.5918.6583.2105.3921.3471.8085.3926 1.2363.088.8272-.1925 1.6886-.8691 2.3652-.7565.7566-1.781 1.0896-2.7735 1 3.1157 1.7478 7.1304 1.2962 9.7813-1.3535 1.337-1.3364 2.1102-3.0208 2.3281-4.7617-1.946.1045-3.9194-.4446-5.5664-1.6426z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
