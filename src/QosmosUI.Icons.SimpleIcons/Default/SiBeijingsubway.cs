// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.SimpleIcons.Default;

public class SiBeijingsubway : ComponentBase
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
		builder.AddAttribute(15, "d", "M10.729 23.936c-2.182-.257-4.152-1.048-5.948-2.389-.586-.437-1.636-1.465-2.11-2.064-1.11-1.404-1.854-2.957-2.313-4.828-.303-1.232-.41-2.309-.335-3.35.069-.955.409-2.437.811-3.536.371-1.014 1.151-2.382 1.864-3.269a15.51 15.51 0 0 1 1.55-1.593C6.625.878 9.607-.14 12.69.026 15.358.17 17.738 1.1 19.738 2.78c1.904 1.6 3.36 3.801 3.883 5.869.067.263.113.486.104.495-.009.009-.636.022-1.392.03l-1.375.014-.132-.342c-.674-1.738-2.194-3.564-3.948-4.743-.806-.541-1.555-.874-2.296-1.021-2.136-.424-4.15-.276-5.829.428C6.21 4.576 4.078 6.948 3.317 9.559c-.222.761-.274 1.185-.273 2.199.002 1.29.139 2.128.549 3.365.497 1.499 1.083 2.438 2.198 3.525 1.249 1.216 2.839 2.146 4.121 2.407 1.463.299 3.868.029 5.887-.662 1.911-.654 3.511-2.086 4.6-4.116.21-.391.681-1.508.682-1.615 0-.045-.076-.05-.437-.03-.241.014-1.02.025-1.731.025h-1.294l-.017.088c-.01.048-.047.245-.082.438-.103.558-.273 1.029-.615 1.705l-.319.63-9.514.02V6.445h9.488l.203.316c.591.922.914 2.116 1.049 3.885.022.288.04.713.04.944v.42H24v.247c0 .372-.105 1.39-.195 1.887-.529 2.932-1.96 5.434-4.086 7.148-1.853 1.493-3.982 2.387-6.306 2.647-.648.072-2.063.07-2.684-.003zm3.64-8.802c.163-.171.404-.539.537-.82.112-.235.123-.295.123-.632 0-.36-.006-.384-.164-.701-.091-.18-.26-.44-.378-.577l-.214-.25.125-.153c.238-.291.308-.401.459-.711.369-.76.232-1.527-.382-2.131l-.187-.184-2.305-.025-2.306-.026.01 3.13.01 3.129 2.277.02c1.252.011 2.28.024 2.285.029s.054-.039.11-.098z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
