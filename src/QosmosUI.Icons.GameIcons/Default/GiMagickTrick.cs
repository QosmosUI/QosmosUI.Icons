// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiMagickTrick : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M313.203 25.94l-.133 24.67-18.12 16.743 24.67.132 16.743 18.12.133-24.67 18.12-16.743-24.67-.132-16.743-18.12zm91.58 50.12L385.47 91.41l-24.4-3.638 15.35 19.313-3.637 24.4 19.313-15.35 24.4 3.637-15.35-19.312 3.637-24.4zM39.87 80.206l-7.116 16.268 7.637 3.34 256 112 8.247 3.607-.1.227.61.266 7.214-16.492-8.243-3.607-44.113-19.298a102.607 43.83 0 0 1 52.088-6.13A102.607 43.83 0 0 1 414.7 214.22a102.607 43.83 0 0 1-102.608 43.83 102.607 43.83 0 0 1-102.608-43.83 102.607 43.83 0 0 1 8.262-17.162l-32.814-14.358c-12.552 5.49-22.514 11.71-29.192 17.96-7.646 7.16-10.802 13.782-10.802 20.134s3.156 12.975 10.802 20.133c7.646 7.158 19.596 14.274 34.81 20.3 30.43 12.047 73.71 19.835 121.542 19.835 47.832 0 91.11-7.788 121.54-19.836 15.215-6.025 27.165-13.14 34.81-20.3 7.647-7.157 10.804-13.78 10.804-20.132 0-6.352-3.157-12.975-10.803-20.133-7.646-7.16-19.596-14.275-34.81-20.3-30.43-12.048-73.71-19.836-121.54-19.836-26.422 0-51.44 2.386-73.683 6.543L48.117 83.813l-8.246-3.607zm204.903 4.31l.077 16.708-12.16 11.46 16.708-.076 11.46 12.16-.075-16.708L272.94 96.6l-16.706.075-11.46-12.16zM215.94 286.592c-.147 15.018-.44 29.74-1.038 44.308 67.544 29.705 126.598 29.746 194.383.113-.6-14.603-.894-29.364-1.043-44.42-27.33 7.925-60.396 12.467-96.15 12.467-35.756 0-68.82-4.54-96.15-12.467zm-2.004 63.467c-.555 8.977-1.254 17.925-2.13 26.877l.555.25c69.454 31.175 129.756 31.177 199.486-.006l.535-.238c-.874-8.92-1.572-17.838-2.126-26.785-66.975 27.646-129.55 27.616-196.318-.097zm200.552 45.595c-70.003 30.062-135.025 30.067-204.793.002-2.287 17.913-5.385 35.95-9.603 54.403 0 48 224 48 224 0-4.218-18.455-7.316-36.49-9.604-54.405z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
