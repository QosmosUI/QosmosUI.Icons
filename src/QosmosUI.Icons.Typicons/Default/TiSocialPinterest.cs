// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiSocialPinterest : ComponentBase
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
		builder.AddAttribute(14, "d", "M12.486 4.771c-4.23 0-6.363 3.033-6.363 5.562 0 1.533.581 2.894 1.823 3.401.205.084.387.004.446-.221l.182-.717c.061-.221.037-.3-.127-.495-.359-.422-.588-.972-.588-1.747 0-2.25 1.683-4.264 4.384-4.264 2.392 0 3.706 1.463 3.706 3.412 0 2.568-1.137 4.734-2.824 4.734-.932 0-1.629-.77-1.405-1.715.268-1.13.786-2.347.786-3.16 0-.729-.392-1.336-1.2-1.336-.952 0-1.718.984-1.718 2.304 0 .841.286 1.409.286 1.409l-1.146 4.852c-.34 1.44-.051 3.206-.025 3.385.013.104.149.131.21.051.088-.115 1.223-1.517 1.607-2.915.111-.396.627-2.445.627-2.445.311.589 1.213 1.108 2.175 1.108 2.863 0 4.804-2.608 4.804-6.103-.003-2.64-2.24-5.1-5.64-5.1z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
